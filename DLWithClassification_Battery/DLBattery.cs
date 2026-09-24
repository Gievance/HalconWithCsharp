using HalconDotNet;
using HalconWithCsharp.DLWithClassification_Battery.Tools;
using Log4netComponent;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static HalconWithCsharp.DLWithClassification_Battery.Tools.HalconDLTool;
using static HalconWithCsharp.GenericTools.MyTools;

namespace HalconWithCsharp.DLWithClassification_Battery
{
    public partial class DLBattery : Form
    {
        public DLBattery()
        {
            InitializeComponent();
            Logger.RegistryLog();
        }
        string[] modelFiles;

        private void DLBattery_Load(object sender, EventArgs e)
        {
            // 设置字体大小
            set_display_font(hswmtrain.HalconWindow, 20, "mono", "true", "false");
            set_display_font(hswmeval.HalconWindow, 20, "mono", "true", "false");
            set_display_font(hswmInfer.HalconWindow, 20, "mono", "true", "false");

            ShowPreprocessAction += RreProcessAction;
            Logger.InitializeRichTextBox(rtb);

            Logger.Info("执行 - 初始化项目");
            Load_Model_to_CBX();
        }

        private void Load_Model_to_CBX()
        {
            string model_path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "hdl");
            if (!Path.Exists(model_path))
            {
                Logger.Info("模型路径不存在");
                DirectoryInfo df = Directory.CreateDirectory(model_path);
                if (df.Exists)
                {
                    Logger.Info($"模型路径:{df.Name} 创建成功");
                }
                else
                {
                    Logger.Info($"模型路径:{df.Name} 创建失败");
                }

            }

            modelFiles = Directory.GetFiles(model_path, "*.hdl");
            if (modelFiles.Length == 0)
            {
                cbx_loadModel.Items.Add("暂无可选模型");
                cbx_loadModel.SelectedIndex = 0;

                return;
            }

            foreach (string p in modelFiles)
            {
                string modelname = Path.GetFileNameWithoutExtension(p);
                cbx_loadModel.Items.Add(modelname);
            }
            if (modelFiles?.Length > 0)
            {
                cbx_loadModel.Items.Insert(0, "请选择模型");
                cbx_loadModel.SelectedIndex = 0;
            }

        }

        #region 预处理界面
        HTuple DLModelHandle;
        string smodelname = ""; // 用于再次使用
        private void cbx_loadModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // 读取模型
                if (cbx_loadModel.SelectedIndex == 0)
                    return;
                smodelname = modelFiles[cbx_loadModel.SelectedIndex - 1];
                HOperatorSet.ReadDlModel(smodelname, out DLModelHandle);

                if (DLModelHandle == null)
                {
                    Logger.Error("错误日志 - 未能读取模型信息");
                    return;
                }
                // 获取模型参数
                HOperatorSet.GetDlModelParam(DLModelHandle, "image_width", out HTuple ImageWidth);
                tb_imagewidth.Text = ImageWidth.ToString();
                HOperatorSet.GetDlModelParam(DLModelHandle, "image_height", out HTuple ImageHeight);
                tb_imageheight.Text = ImageHeight.ToString();
                HOperatorSet.GetDlModelParam(DLModelHandle, "image_num_channels", out HTuple ImageChannel);
                tb_channels.Text = ImageChannel.ToString();
                HOperatorSet.GetDlModelParam(DLModelHandle, "image_range_max", out HTuple ImageRmax);
                tb_maxgrey.Text = ImageRmax.ToString();
                HOperatorSet.GetDlModelParam(DLModelHandle, "image_range_min", out HTuple ImageRmin);
                tb_mingrey.Text = ImageRmin.ToString();



                //// 训练界面的初始化
                //tb_selModel.Text = new FileInfo(smodelname).Name;
                //// 总周期，评估周期，学习率，随机种子
                //HOperatorSet.GetDlModelParam(DLModelHandle, "learning_rate", out HTuple Lr);
                //tb_trainPLr.Text = Lr.ToString();
                //HOperatorSet.GetDlModelParam(DLModelHandle, "batch_size", out HTuple BatchSize);
                //tb_trainPBatch.Text = BatchSize.ToString();


            }
            catch (Exception ex)
            {
                Logger.Error("错误日志 - 加载模型失败");
            }
        }
        private string? samplepath;
        private HTuple className = new HTuple();
        private void btn_samplePath_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                fbd.Description = "请选择文件夹";
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    samplepath = fbd.SelectedPath;
                }
            }

            if (samplepath == null)
                return;
            // 获取类别信息
            string[] dirs = Directory.GetDirectories(samplepath);
            foreach (string c in dirs)
            {
                className.Append(new FileInfo(c).Name);
            }


            tb_samplePath.Text = samplepath;
        }

        private string storagepath;
        private void btn_storagePath_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                fbd.Description = "请选择存储文件夹";
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    storagepath = fbd.SelectedPath;
                }
            }


            tb_storagePath.Text = storagepath;


        }
        HTuple DLDataset;
        private void btn_preprocess_Click(object sender, EventArgs e)
        {
            // 读取数据集
            var dataset_dirs = new HTuple(samplepath) + "\\" + className;
            // dataset_dirs 第一个参数接受的是子目录集合
            ReadDLDatasetClassification(dataset_dirs, "last_folder", out DLDataset);

            // 多线程进行预处理操作（方便显示图片）
            Thread t_preprocess = new Thread(ImageProcess);
            t_preprocess.IsBackground = true;
            t_preprocess.Start();
            Logger.Info("日志 - 预处理完成");

        }

        HTuple DLPreprocessParam;
        private Action<HObject> ShowPreprocessAction;
        private void RreProcessAction(HObject obj)
        {
            if (obj != null)
            {
                hswm.HalconWindow.DispObj(obj);
                hswm.SetFullImagePart();
            }
        }
        private void ImageProcess(object obj)
        {
            // 1. 创建预处理参数； 2. 执行预处理 3. 保存预处理参数
            try
            {
                // 创建预处理参数
                HTuple ImageWidth = Convert.ToInt32(tb_imagewidth.Text);
                HTuple ImageHeight = Convert.ToInt32(tb_imageheight.Text);
                HTuple ImageChannel = Convert.ToInt32(tb_channels.Text);
                HTuple ImageRmin = Convert.ToInt32(tb_mingrey.Text);
                HTuple ImageRmax = Convert.ToInt32(tb_maxgrey.Text);
                CreateDLPreprocessParam("classification", ImageWidth, ImageHeight, ImageChannel, ImageRmin, ImageRmax, "none", "full_domain", new HTuple(), new HTuple(), new HTuple(), new HTuple(), out DLPreprocessParam);

                // 进行预处理; ShowPreprocessAction是图像更新时的委托
                HOperatorSet.CreateDict(out HTuple GenParam);
                HOperatorSet.SetDictTuple(GenParam, "overwrite_files", "true");
                PreprocessDLDataset(DLDataset, storagepath, DLPreprocessParam, GenParam, ShowPreprocessAction, out HTuple DLDatasetFileName);
                // 显示处理完成
                HOperatorSet.DispText(hswm.HalconWindow, "预处理完成", "window", 15, 15, "white", "box_color", "forest green");


            }
            catch (Exception ex)
            {
                Logger.Error("错误 - 预处理失败");
            }
            finally
            {
                // 保存预处理参数
                string param_savepath = Path.Combine(storagepath, "PreprocessParam.hdict");
                HOperatorSet.WriteDict(DLPreprocessParam, new HTuple(param_savepath), new HTuple(), new HTuple());

                if (DLModelHandle != null)
                {

                    // 将类别属性放置模型中
                    HOperatorSet.SetDlModelParam(DLModelHandle, "class_names", className);
                    string save_model_path = Path.Combine(storagepath, "Loaded_Model.hdl");
                    HOperatorSet.WriteDlModel(DLModelHandle, save_model_path);
                    HOperatorSet.ClearDlModel(DLModelHandle);
                    DLModelHandle.Dispose();
                    DLModelHandle = null;
                }

                if (DLDataset != null)
                {
                    DLDataset.Dispose();
                    DLDataset = null;
                }
            }
        }
        #endregion

        #region 模型训练

        string dsPath;
        /// <summary>
        /// 数据集选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_LoadDs_Click(object sender, EventArgs e)
        {
            if (DLDataset != null)
                return;

            // 数据集文件
            dsPath = GetOpenFilePath(samplepath, "hdict");
            if(dsPath.IsWhiteSpace())
            {
                return;
            }
            btn_LoadDs.Tag = dsPath;
            HOperatorSet.ReadDict(dsPath, new HTuple(), new HTuple(), out DLDataset);
            btn_LoadDs.Text = "已选择数据集";
            Logger.Info($"日志 - 数据集加载完成:{dsPath}");
        }

        private void btn_trainModel_Click(object sender, EventArgs e)
        {
            // 加载训练模型
            load_TrainModel();
            // 划分数据集
            SplitDataset();

            // 设置训练参数
            HTuple GenParamName;
            HTuple GenParamValue;
            Set_TrainParam(out GenParamName, out GenParamValue);
            // 训练模型
            Train_Model(GenParamName, GenParamValue);

        }

        private void load_TrainModel()
        {
            try
            {
                if (DLModelHandle != null)
                    return;
                // 读取模型文件
                HOperatorSet.ReadDlModel(smodelname, out DLModelHandle);
                Logger.Info("日志 - 加载模型成功");
            }
            catch (Exception ex)
            {
                Logger.Error("错误 - 加载模型失败");
            }
        }

        private void SplitDataset()
        {
            try
            {
                if (tb_trainTrainP.Text.IsWhiteSpace() || tb_trainValP.Text.IsWhiteSpace())
                {
                    MessageBox.Show("未设置数据集划分", "模型训练", MessageBoxButtons.OK);
                    return;
                }
                int train = Convert.ToInt32(tb_trainTrainP.Text);
                int val = Convert.ToInt32(tb_trainValP.Text);

                if (DLDataset != null)
                {
                    HOperatorSet.CreateDict(out HTuple GenParam);
                    HOperatorSet.SetDictTuple(GenParam, "overwrite_split", "true");
                    SplitDlDataset(DLDataset, new HTuple(train), new HTuple(val), GenParam);

                    string save_ds = Path.Combine(Path.GetDirectoryName(dsPath), "splitdataset.hdict");
                    btn_LoadDs.Tag = save_ds;
                    HOperatorSet.WriteDict(DLDataset, save_ds, new HTuple(), new HTuple()); // 再次保存划分后的数据集句柄
                }
            }
            catch (Exception ex)
            {
                Logger.Error("错误 - 划分数据集失败");
            }
        }


        HTuple TrainParam;
        private void Set_TrainParam(out HTuple GenParamName, out HTuple GenParamValue)
        {
            GenParamName = new HTuple();
            GenParamValue = new HTuple();
            if (DLModelHandle == null)
            {
                Logger.Error("错误 - 设置训练参数 - 模型句柄不存在");
                return;
            }
            try
            {

                if (tb_trainPBatch.Text.IsWhiteSpace())
                {
                    SimpMessageBox("未设置批次大小");
                    return;
                }
                int batchsize = Convert.ToInt32(tb_trainPBatch.Text);



                if (tb_trainPLr.Text.IsWhiteSpace())
                {
                    SimpMessageBox("未设置学习率");
                    return;
                }
                double lr = Convert.ToDouble(tb_trainPLr.Text);

                int ImageWidth = Convert.ToInt32(tb_imagewidth.Text);
                int ImageHeight = Convert.ToInt32(tb_imageheight.Text);
                int ImageChannel = Convert.ToInt32(tb_channels.Text);
                // 设置训练参数
                if (className.Length == 0) // className是在预处理阶段构建的，直接训练则为空
                {
                    string rp = Path.GetDirectoryName(samplepath);

                }
                HOperatorSet.SetDlModelParam(DLModelHandle, "class_names", className);
                HOperatorSet.SetDlModelParam(DLModelHandle, "batch_size", new HTuple(batchsize));
                HOperatorSet.SetDlModelParam(DLModelHandle, "image_dimensions", new HTuple(ImageWidth, ImageHeight, ImageChannel));
                HOperatorSet.SetDlModelParam(DLModelHandle, "learning_rate", new HTuple(lr));
                // 设置扩展参数
                // 创建增强参数字典
                HOperatorSet.CreateDict(out HTuple augmentDict);
                HOperatorSet.SetDictTuple(augmentDict, "augmentation_percentage", 100);
                HOperatorSet.SetDictTuple(augmentDict, "mirror", "rc");
                // 设置增强参数
                GenParamName.Append("augment");
                GenParamValue.Append(augmentDict);

                // 设置保存最佳模型和最终模型的参数
                HOperatorSet.CreateDict(out HTuple bestSerializeDict);
                HOperatorSet.SetDictTuple(bestSerializeDict, "type", "best");
                HOperatorSet.SetDictTuple(bestSerializeDict, "basename", $"best_{new FileInfo(smodelname).Name}");
                GenParamName.Append("serialize");
                GenParamValue.Append(bestSerializeDict);

                HOperatorSet.CreateDict(out HTuple finalSerializeDict);
                HOperatorSet.SetDictTuple(finalSerializeDict, "type", "final");
                HOperatorSet.SetDictTuple(finalSerializeDict, "basename", $"final_{new FileInfo(smodelname).Name}");
                GenParamName.Append("serialize");
                GenParamValue.Append(finalSerializeDict);

            }
            catch (Exception ex)
            {
                Logger.Error("错误 - 训练参数设置失败");
            }
        }

        private async void Train_Model(HTuple genParamName, HTuple genParamValue)
        {
            if (DLDataset == null || DLModelHandle == null)
            {
                SimpMessageBox("数据集|模型 句柄不存在");
                return;
            }

            try
            {
                if (tb_trainPEpochs.Text.IsWhiteSpace())
                {
                    SimpMessageBox("未设置总周期");
                    return;
                }
                // 获取训练参数
                int epochs = Convert.ToInt32(tb_trainPEpochs.Text);

                if (tb_trainPEvalEpoch.Text.IsWhiteSpace())
                {
                    SimpMessageBox("未设置评估周期");
                    return;
                }
                int vepoch = Convert.ToInt32(tb_trainPEvalEpoch.Text);

                if (tb_trainPSeed.Text.IsWhiteSpace())
                {
                    SimpMessageBox("未设置随机种子");
                    return;
                }
                int seed = Convert.ToInt32(tb_trainPSeed.Text);


                // 创建训练参数
                CreateDLTrainParam(DLModelHandle, epochs, vepoch, "true", seed, genParamName, genParamValue, out HTuple TrainParam);
                // 训练模型
                await Task.Run(() =>
                {
                    hswmtrain.HalconWindow.SetWindowParam("background_color", "white");
                    hswmtrain.SetFullImagePart();
                    TrainDLModel(DLDataset, DLModelHandle, TrainParam, 0, hswmtrain.HalconWindow, out HTuple TrainResults, out HTuple TrainInfos, out HTuple EvaluationInfos);
                });
                Logger.Info("日志 - 模型训练完成");
            }
            catch (Exception ex)
            {
                Logger.Error($"错误 - 模型训练失败:{ex.Message}");
            }
            finally
            {
                btn_LoadDs.Text = "选择数据集";
                if (DLDataset != null)
                {
                    DLDataset.Dispose();
                    DLDataset = null;
                }
                if (DLModelHandle != null)
                {
                    HOperatorSet.ClearDlModel(DLModelHandle);
                    DLModelHandle.Dispose();
                    DLModelHandle = null;
                }
            }
        }

        

        private void btn_loadModel_Click(object sender, EventArgs e)
        {
            try
            {
                string model_path = GetOpenFilePath(AppDomain.CurrentDomain.BaseDirectory, "hdl"); // 获取模型路径
                tb_selModel.Text = Path.GetFileNameWithoutExtension(model_path);
                HOperatorSet.ReadDlModel(model_path, out DLModelHandle);
                if (DLModelHandle == null)
                    return;
                // 总周期，评估周期，学习率，随机种子
                HOperatorSet.GetDlModelParam(DLModelHandle, "learning_rate", out HTuple Lr);
                tb_trainPLr.Text = Lr.D.ToString("0.00000");
                HOperatorSet.GetDlModelParam(DLModelHandle, "batch_size", out HTuple BatchSize);
                tb_trainPBatch.Text = BatchSize.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("错误 - 模型训练 - 加载模型失败");
            }


        }
        #endregion

        #region 评估指标
        string sel_model;
        private void btn_3_model_Click(object sender, EventArgs e)
        {
            sel_model = GetOpenFilePath(AppDomain.CurrentDomain.BaseDirectory, "hdl");
            tb_3_model.Text = new FileInfo(sel_model).Name;

        }
        /// <summary>
        /// 进行模型评估
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_EvalExe_Click(object sender, EventArgs e)
        {
            if (sel_model == null || sel_model.IsWhiteSpace())
            {
                SimpMessageBox("未选择模型");
                return;
            }
            if (cbx_metric.Text.IsWhiteSpace())
            {
                SimpMessageBox("未选择评估指标");
                return;
            }
            if (cbx_data.Text.IsWhiteSpace())
            {
                SimpMessageBox("未选择评估数据");
                return;
            }
            try
            {
                // 读取模型
                HOperatorSet.ReadDlModel(sel_model, out HTuple dLModelHandle);
                // 获取评估指标
                string metric = cbx_metric.Text;
                // 获取评估数据
                string datatype;
                switch (cbx_data.Text)
                {
                    case "验证集": datatype = "validation"; break;
                    case "测试集": datatype = "test"; break;
                    default: return;
                }
                if (DLModelHandle == null)
                {
                    HOperatorSet.ReadDlModel(sel_model, out DLModelHandle);
                }

                if (DLDataset == null)
                {
                    HOperatorSet.ReadDict(Path.Combine(tb_storagePath.Text, "splitdataset.hdict"), new HTuple(), new HTuple(), out DLDataset);
                }
                HOperatorSet.CreateDict(out HTuple metricDict);
                HOperatorSet.SetDictTuple(metricDict, "measures", new HTuple("f_score", metric));

                EvaluateDlModel(DLDataset, DLModelHandle, "split", datatype, metricDict, out HTuple EvaluationResult, out HTuple EvalParams);

                // 显示评估结果
                var DisParam = new HTuple("measures");
                var windowname = string.Empty;
                if (metric == "recall" || metric == "precision")
                {
                    DisParam.Append($"pie_charts_{metric}");
                    windowname = $"window_pie_charts_{metric}";
                }
                else
                {
                    DisParam.Append($"{metric}");
                    windowname = $"window_{metric}";
                }
                HOperatorSet.CreateDict(out HTuple GenParam);
                HOperatorSet.SetDictTuple(GenParam, "display_mode", DisParam);
                HOperatorSet.CreateDict(out HTuple WindowHandle);
                HOperatorSet.SetDictTuple(WindowHandle, windowname, hswmeval.HalconWindow);
                hswmeval.SetFullImagePart();
                DisplayClassificationEvaluation(EvaluationResult, EvalParams, GenParam, WindowHandle);
            }
            catch (Exception ex)
            {
                Logger.Error("错误 - 模型评估失败");
            }
            finally
            {
                if (DLDataset != null)
                {
                    DLDataset.Dispose();
                    DLDataset = null;
                }

                if (DLModelHandle != null)
                {
                    HOperatorSet.ClearDlModel(DLModelHandle);
                    DLModelHandle.Dispose();
                    DLModelHandle = null;
                }
            }

        }

        #endregion
        #region 模型推断
        string sel_model_path;
        private void btn_4_selModel_Click(object sender, EventArgs e)
        {
            // 获取模型路径,不执行模型加载。
            sel_model_path = GetOpenFilePath(AppDomain.CurrentDomain.BaseDirectory, "hdl");
            tb1.Text = new FileInfo(sel_model_path).Name;
        }



        List<string> sel_data_path;
        private void btn_4_selData_Click(object sender, EventArgs e)
        {
            // 获取带推断图像
            sel_data_path = GetOpenFilePaths(AppDomain.CurrentDomain.BaseDirectory, "*");
            StringBuilder sb = new StringBuilder();
            foreach (string s in sel_data_path)
            {
                string name = new FileInfo(s).Name;
                sb.Append(name + ";");
            }
            tb2.Text = sb.ToString();
        }
        int idx=0;

        private void btn_4_ExeInfer_Click(object sender, EventArgs e)
        {
            try
            {    // 预处理参数
                if (storagepath == null || storagepath.IsWhiteSpace())
                {
                    SimpMessageBox("未选择存储路径，无法读取预训练参数");
                }
               
                HOperatorSet.ReadDict(Path.Combine(storagepath, "PreprocessParam.hdict"), new HTuple(), new HTuple(), out HTuple preprocessParam);
                
                // 推断模型
                if (DLModelHandle == null)
                {
                    HOperatorSet.ReadDlModel(sel_model_path, out DLModelHandle);
                }

                // 执行推断
                HOperatorSet.CountSeconds(out HTuple StartTime);


                HOperatorSet.ReadImage(out HObject Image, sel_data_path[idx++]);
                gen_dl_samples_from_images(Image, out HTuple DLSampleBatch); // 构建samples
                HOperatorSet.GetDictObject(out HObject image, DLSampleBatch, "image");

                preprocess_dl_samples(DLSampleBatch, preprocessParam); // 预处理样本

                HOperatorSet.ApplyDlModel(DLModelHandle, DLSampleBatch, new HTuple(), out HTuple DLResultBatch);

                HOperatorSet.CountSeconds(out HTuple endTime);


                // 显示
                HOperatorSet.GetDictTuple(DLResultBatch, "classification_class_names",out HTuple classname);
                HOperatorSet.GetDictTuple(DLResultBatch, "classification_confidences", out HTuple confidence);
                tb_retClass.Text = classname[0].S.ToString();
                tb_Score.Text = confidence[0].D.ToString();
                tb_Time.Text = ((endTime - StartTime).D * 1000).ToString("F4");


                var winhandle = hswmInfer.HalconWindow;
                winhandle.DispObj(image);
                hswmInfer.SetFullImagePart();

                HOperatorSet.DispText(winhandle, $"推断结果：{classname[0].S}", "window", 15, 15, "white", "box_color", "forest green");
                if(idx >=sel_data_path.Count)
                {
                    idx = 0;
                }
                


            }
            catch(Exception ex)
            {
                Logger.Error("错误 - 模型推断失败");
            }
            finally
            {
                if (DLModelHandle != null)
                {
                    HOperatorSet.ClearDlModel(DLModelHandle);
                    DLModelHandle.Dispose();
                    DLModelHandle = null;
                }
            }
        }

        #endregion
    }
}
