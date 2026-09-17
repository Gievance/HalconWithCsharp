using HalconDotNet;
using System;
using System.Windows.Forms;

namespace HalconWithCsharp.Pipe3DMatching.Tools
{
    /// <summary>
    /// 显示3D数据工具类
    /// </summary>
    public class VisualizeModel3D
    {

        public HTuple hv_ExpDefaultWinHandle;

        HTuple gIsSinglePose;
        HTuple gTerminationButtonLabel;
        HTuple gInfoDecor;
        HTuple gInfoPos;
        HTuple gTitlePos;
        HTuple gTitleDecor;
        HTuple gAlphaDeselected;
        HTuple gDispObjOffset;
        HTuple gLabelsDecor;
        HTuple gUsesOpenGL;
        public bool ExitLoop = false;//方便手动退出

        public bool Exi = true;



        HTuple ExpGetGlobalVar_gIsSinglePose()
        {
            return gIsSinglePose;
        }
        void ExpSetGlobalVar_gIsSinglePose(HTuple val)
        {
            gIsSinglePose = val;
        }

        HTuple ExpGetGlobalVar_gTerminationButtonLabel()
        {
            return gTerminationButtonLabel;
        }
        void ExpSetGlobalVar_gTerminationButtonLabel(HTuple val)
        {
            gTerminationButtonLabel = val;
        }

        HTuple ExpGetGlobalVar_gInfoDecor()
        {
            return gInfoDecor;
        }
        void ExpSetGlobalVar_gInfoDecor(HTuple val)
        {
            gInfoDecor = val;
        }

        HTuple ExpGetGlobalVar_gInfoPos()
        {
            return gInfoPos;
        }
        void ExpSetGlobalVar_gInfoPos(HTuple val)
        {
            gInfoPos = val;
        }

        HTuple ExpGetGlobalVar_gTitlePos()
        {
            return gTitlePos;
        }
        void ExpSetGlobalVar_gTitlePos(HTuple val)
        {
            gTitlePos = val;
        }

        HTuple ExpGetGlobalVar_gTitleDecor()
        {
            return gTitleDecor;
        }
        void ExpSetGlobalVar_gTitleDecor(HTuple val)
        {
            gTitleDecor = val;
        }

        HTuple ExpGetGlobalVar_gAlphaDeselected()
        {
            return gAlphaDeselected;
        }
        void ExpSetGlobalVar_gAlphaDeselected(HTuple val)
        {
            gAlphaDeselected = val;
        }

        HTuple ExpGetGlobalVar_gDispObjOffset()
        {
            return gDispObjOffset;
        }
        void ExpSetGlobalVar_gDispObjOffset(HTuple val)
        {
            gDispObjOffset = val;
        }

        HTuple ExpGetGlobalVar_gLabelsDecor()
        {
            return gLabelsDecor;
        }
        void ExpSetGlobalVar_gLabelsDecor(HTuple val)
        {
            gLabelsDecor = val;
        }

        HTuple ExpGetGlobalVar_gUsesOpenGL()
        {
            return gUsesOpenGL;
        }
        void ExpSetGlobalVar_gUsesOpenGL(HTuple val)
        {
            gUsesOpenGL = val;
        }

        // Procedures 
        // External procedures 
        // Chapter: Develop
        // Short Description: Switch dev_update_pc, dev_update_var and dev_update_window to 'off'. 
        public void dev_update_off()
        {

            // Initialize local and output iconic variables 
            //This procedure sets different update settings to 'off'.
            //This is useful to get the best performance and reduce overhead.
            //
            // dev_update_pc(...); only in hdevelop
            // dev_update_var(...); only in hdevelop
            // dev_update_window(...); only in hdevelop

            return;
        }

        // Chapter: Graphics / Text
        // Short Description: This procedure writes a text message. 
        public void disp_message(HTuple hv_WindowHandle, HTuple hv_String, HTuple hv_CoordSystem,
            HTuple hv_Row, HTuple hv_Column, HTuple hv_Color, HTuple hv_Box)
        {



            // Local iconic variables 

            // Local control variables 

            HTuple hv_GenParamName = null, hv_GenParamValue = null;
            HTuple hv_Color_COPY_INP_TMP = hv_Color.Clone();
            HTuple hv_Column_COPY_INP_TMP = hv_Column.Clone();
            HTuple hv_CoordSystem_COPY_INP_TMP = hv_CoordSystem.Clone();
            HTuple hv_Row_COPY_INP_TMP = hv_Row.Clone();

            // Initialize local and output iconic variables 
            //This procedure displays text in a graphics window.
            //
            //Input parameters:
            //WindowHandle: The WindowHandle of the graphics window, where
            //   the message should be displayed
            //String: A tuple of strings containing the text message to be displayed
            //CoordSystem: If set to 'window', the text position is given
            //   with respect to the window coordinate system.
            //   If set to 'image', image coordinates are used.
            //   (This may be useful in zoomed images.)
            //Row: The row coordinate of the desired text position
            //   A tuple of values is allowed to display text at different
            //   positions.
            //Column: The column coordinate of the desired text position
            //   A tuple of values is allowed to display text at different
            //   positions.
            //Color: defines the color of the text as string.
            //   If set to [], '' or 'auto' the currently set color is used.
            //   If a tuple of strings is passed, the colors are used cyclically...
            //   - if |Row| == |Column| == 1: for each new textline
            //   = else for each text position.
            //Box: If Box[0] is set to 'true', the text is written within an orange box.
            //     If set to' false', no box is displayed.
            //     If set to a color string (e.g. 'white', '#FF00CC', etc.),
            //       the text is written in a box of that color.
            //     An optional second value for Box (Box[1]) controls if a shadow is displayed:
            //       'true' -> display a shadow in a default color
            //       'false' -> display no shadow
            //       otherwise -> use given string as color string for the shadow color
            //
            //It is possible to display multiple text strings in a single call.
            //In this case, some restrictions apply:
            //- Multiple text positions can be defined by specifying a tuple
            //  with multiple Row and/or Column coordinates, i.e.:
            //  - |Row| == n, |Column| == n
            //  - |Row| == n, |Column| == 1
            //  - |Row| == 1, |Column| == n
            //- If |Row| == |Column| == 1,
            //  each element of String is display in a new textline.
            //- If multiple positions or specified, the number of Strings
            //  must match the number of positions, i.e.:
            //  - Either |String| == n (each string is displayed at the
            //                          corresponding position),
            //  - or     |String| == 1 (The string is displayed n times).
            //
            //
            //Convert the parameters for disp_text.
            if ((int)new HTuple(hv_Row_COPY_INP_TMP.TupleEqual(new HTuple())).TupleOr(
                new HTuple(hv_Column_COPY_INP_TMP.TupleEqual(new HTuple()))) != 0)
            {

                return;
            }
            if ((int)new HTuple(hv_Row_COPY_INP_TMP.TupleEqual(-1)) != 0)
            {
                hv_Row_COPY_INP_TMP = 12;
            }
            if ((int)new HTuple(hv_Column_COPY_INP_TMP.TupleEqual(-1)) != 0)
            {
                hv_Column_COPY_INP_TMP = 12;
            }
            //
            //Convert the parameter Box to generic parameters.
            hv_GenParamName = new HTuple();
            hv_GenParamValue = new HTuple();
            if ((int)new HTuple(new HTuple(hv_Box.TupleLength()).TupleGreater(0)) != 0)
            {
                if ((int)new HTuple(hv_Box.TupleSelect(0).TupleEqual("false")) != 0)
                {
                    //Display no box
                    hv_GenParamName = hv_GenParamName.TupleConcat("box");
                    hv_GenParamValue = hv_GenParamValue.TupleConcat("false");
                }
                else if ((int)new HTuple(hv_Box.TupleSelect(0).TupleNotEqual("true")) != 0)
                {
                    //Set a color other than the default.
                    hv_GenParamName = hv_GenParamName.TupleConcat("box_color");
                    hv_GenParamValue = hv_GenParamValue.TupleConcat(hv_Box.TupleSelect(0));
                }
            }
            if ((int)new HTuple(new HTuple(hv_Box.TupleLength()).TupleGreater(1)) != 0)
            {
                if ((int)new HTuple(hv_Box.TupleSelect(1).TupleEqual("false")) != 0)
                {
                    //Display no shadow.
                    hv_GenParamName = hv_GenParamName.TupleConcat("shadow");
                    hv_GenParamValue = hv_GenParamValue.TupleConcat("false");
                }
                else if ((int)new HTuple(hv_Box.TupleSelect(1).TupleNotEqual("true")) != 0)
                {
                    //Set a shadow color other than the default.
                    hv_GenParamName = hv_GenParamName.TupleConcat("shadow_color");
                    hv_GenParamValue = hv_GenParamValue.TupleConcat(hv_Box.TupleSelect(1));
                }
            }
            //Restore default CoordSystem behavior.
            if ((int)new HTuple(hv_CoordSystem_COPY_INP_TMP.TupleNotEqual("window")) != 0)
            {
                hv_CoordSystem_COPY_INP_TMP = "image";
            }
            //
            if ((int)new HTuple(hv_Color_COPY_INP_TMP.TupleEqual("")) != 0)
            {
                //disp_text does not accept an empty string for Color.
                hv_Color_COPY_INP_TMP = new HTuple();
            }
            //
            HOperatorSet.DispText(hv_ExpDefaultWinHandle, hv_String, hv_CoordSystem_COPY_INP_TMP,
                hv_Row_COPY_INP_TMP, hv_Column_COPY_INP_TMP, hv_Color_COPY_INP_TMP, hv_GenParamName,
                hv_GenParamValue);

            return;
        }

        // Chapter: Graphics / Text
        // Short Description: Set font independent of OS 
        public void set_display_font(HTuple hv_WindowHandle, HTuple hv_Size, HTuple hv_Font,
            HTuple hv_Bold, HTuple hv_Slant)
        {



            // Local iconic variables 

            // Local control variables 

            HTuple hv_OS = null, hv_Fonts = new HTuple();
            HTuple hv_Style = null, hv_Exception = new HTuple(), hv_AvailableFonts = null;
            HTuple hv_Fdx = null, hv_Indices = new HTuple();
            HTuple hv_Font_COPY_INP_TMP = hv_Font.Clone();
            HTuple hv_Size_COPY_INP_TMP = hv_Size.Clone();

            // Initialize local and output iconic variables 
            //This procedure sets the text font of the current window with
            //the specified attributes.
            //
            //Input parameters:
            //WindowHandle: The graphics window for which the font will be set
            //Size: The font size. If Size=-1, the default of 16 is used.
            //Bold: If set to 'true', a bold font is used
            //Slant: If set to 'true', a slanted font is used
            //
            HOperatorSet.GetSystem("operating_system", out hv_OS);
            // dev_get_preferences(...); only in hdevelop
            // dev_set_preferences(...); only in hdevelop
            if ((int)new HTuple(hv_Size_COPY_INP_TMP.TupleEqual(new HTuple())).TupleOr(
                new HTuple(hv_Size_COPY_INP_TMP.TupleEqual(-1))) != 0)
            {
                hv_Size_COPY_INP_TMP = 16;
            }
            if ((int)new HTuple(hv_OS.TupleSubstr(0, 2).TupleEqual("Win")) != 0)
            {
                //Restore previous behaviour
                hv_Size_COPY_INP_TMP = (1.13677 * hv_Size_COPY_INP_TMP).TupleInt();
            }
            else
            {
                hv_Size_COPY_INP_TMP = hv_Size_COPY_INP_TMP.TupleInt();
            }
            if ((int)new HTuple(hv_Font_COPY_INP_TMP.TupleEqual("Courier")) != 0)
            {
                hv_Fonts = new HTuple();
                hv_Fonts[0] = "Courier";
                hv_Fonts[1] = "Courier 10 Pitch";
                hv_Fonts[2] = "Courier New";
                hv_Fonts[3] = "CourierNew";
                hv_Fonts[4] = "Liberation Mono";
            }
            else if ((int)new HTuple(hv_Font_COPY_INP_TMP.TupleEqual("mono")) != 0)
            {
                hv_Fonts = new HTuple();
                hv_Fonts[0] = "Consolas";
                hv_Fonts[1] = "Menlo";
                hv_Fonts[2] = "Courier";
                hv_Fonts[3] = "Courier 10 Pitch";
                hv_Fonts[4] = "FreeMono";
                hv_Fonts[5] = "Liberation Mono";
            }
            else if ((int)new HTuple(hv_Font_COPY_INP_TMP.TupleEqual("sans")) != 0)
            {
                hv_Fonts = new HTuple();
                hv_Fonts[0] = "Luxi Sans";
                hv_Fonts[1] = "DejaVu Sans";
                hv_Fonts[2] = "FreeSans";
                hv_Fonts[3] = "Arial";
                hv_Fonts[4] = "Liberation Sans";
            }
            else if ((int)new HTuple(hv_Font_COPY_INP_TMP.TupleEqual("serif")) != 0)
            {
                hv_Fonts = new HTuple();
                hv_Fonts[0] = "Times New Roman";
                hv_Fonts[1] = "Luxi Serif";
                hv_Fonts[2] = "DejaVu Serif";
                hv_Fonts[3] = "FreeSerif";
                hv_Fonts[4] = "Utopia";
                hv_Fonts[5] = "Liberation Serif";
            }
            else
            {
                hv_Fonts = hv_Font_COPY_INP_TMP.Clone();
            }
            hv_Style = "";
            if ((int)new HTuple(hv_Bold.TupleEqual("true")) != 0)
            {
                hv_Style = hv_Style + "Bold";
            }
            else if ((int)new HTuple(hv_Bold.TupleNotEqual("false")) != 0)
            {
                hv_Exception = "Wrong value of control parameter Bold";
                throw new HalconException(hv_Exception);
            }
            if ((int)new HTuple(hv_Slant.TupleEqual("true")) != 0)
            {
                hv_Style = hv_Style + "Italic";
            }
            else if ((int)new HTuple(hv_Slant.TupleNotEqual("false")) != 0)
            {
                hv_Exception = "Wrong value of control parameter Slant";
                throw new HalconException(hv_Exception);
            }
            if ((int)new HTuple(hv_Style.TupleEqual("")) != 0)
            {
                hv_Style = "Normal";
            }
            HOperatorSet.QueryFont(hv_ExpDefaultWinHandle, out hv_AvailableFonts);
            hv_Font_COPY_INP_TMP = "";
            for (hv_Fdx = 0; (int)hv_Fdx <= (int)(new HTuple(hv_Fonts.TupleLength()) - 1); hv_Fdx = (int)hv_Fdx + 1)
            {
                Application.DoEvents();
                hv_Indices = hv_AvailableFonts.TupleFind(hv_Fonts.TupleSelect(hv_Fdx));
                if ((int)new HTuple(new HTuple(hv_Indices.TupleLength()).TupleGreater(0)) != 0)
                {
                    if ((int)new HTuple(hv_Indices.TupleSelect(0).TupleGreaterEqual(0)) != 0)
                    {
                        hv_Font_COPY_INP_TMP = hv_Fonts.TupleSelect(hv_Fdx);
                        break;
                    }
                }
            }
            if ((int)new HTuple(hv_Font_COPY_INP_TMP.TupleEqual("")) != 0)
            {
                throw new HalconException("Wrong value of control parameter Font");
            }
            hv_Font_COPY_INP_TMP = hv_Font_COPY_INP_TMP + "-" + hv_Style + "-" + hv_Size_COPY_INP_TMP;
            HOperatorSet.SetFont(hv_ExpDefaultWinHandle, hv_Font_COPY_INP_TMP);
            // dev_set_preferences(...); only in hdevelop

            return;
        }

        // Chapter: Calibration / Camera Parameters
        // Short Description: Generate a camera parameter tuple for an area scan camera with distortions modeled by the division model. 
        public void gen_cam_par_area_scan_division(HTuple hv_Focus, HTuple hv_Kappa, HTuple hv_Sx,
            HTuple hv_Sy, HTuple hv_Cx, HTuple hv_Cy, HTuple hv_ImageWidth, HTuple hv_ImageHeight,
            out HTuple hv_CameraParam)
        {



            // Local iconic variables 
            // Initialize local and output iconic variables 
            //Generate a camera parameter tuple for an area scan camera
            //with distortions modeled by the division model.
            //
            hv_CameraParam = new HTuple();
            hv_CameraParam[0] = "area_scan_division";
            hv_CameraParam = hv_CameraParam.TupleConcat(hv_Focus);
            hv_CameraParam = hv_CameraParam.TupleConcat(hv_Kappa);
            hv_CameraParam = hv_CameraParam.TupleConcat(hv_Sx);
            hv_CameraParam = hv_CameraParam.TupleConcat(hv_Sy);
            hv_CameraParam = hv_CameraParam.TupleConcat(hv_Cx);
            hv_CameraParam = hv_CameraParam.TupleConcat(hv_Cy);
            hv_CameraParam = hv_CameraParam.TupleConcat(hv_ImageWidth);
            hv_CameraParam = hv_CameraParam.TupleConcat(hv_ImageHeight);

            return;
        }

        // Chapter: Calibration / Camera Parameters
        // Short Description: Get the value of a specified camera parameter from the camera parameter tuple. 
        public void get_cam_par_data(HTuple hv_CameraParam, HTuple hv_ParamName, out HTuple hv_ParamValue)
        {



            // Local iconic variables 

            // Local control variables 

            HTuple hv_CameraType = null, hv_CameraParamNames = null;
            HTuple hv_Index = null, hv_ParamNameInd = new HTuple();
            HTuple hv_I = new HTuple();
            // Initialize local and output iconic variables 
            //get_cam_par_data returns in ParamValue the value of the
            //parameter that is given in ParamName from the tuple of
            //camera parameters that is given in CameraParam.
            //
            //Get the parameter names that correspond to the
            //elements in the input camera parameter tuple.
            get_cam_par_names(hv_CameraParam, out hv_CameraType, out hv_CameraParamNames);
            //
            //Find the index of the requested camera data and return
            //the corresponding value.
            hv_ParamValue = new HTuple();
            for (hv_Index = 0; (int)hv_Index <= (int)(new HTuple(hv_ParamName.TupleLength()) - 1); hv_Index = (int)hv_Index + 1)
            {
                Application.DoEvents();
                hv_ParamNameInd = hv_ParamName.TupleSelect(hv_Index);
                if ((int)new HTuple(hv_ParamNameInd.TupleEqual("camera_type")) != 0)
                {
                    hv_ParamValue = hv_ParamValue.TupleConcat(hv_CameraType);
                    continue;
                }
                hv_I = hv_CameraParamNames.TupleFind(hv_ParamNameInd);
                if ((int)new HTuple(hv_I.TupleNotEqual(-1)) != 0)
                {
                    hv_ParamValue = hv_ParamValue.TupleConcat(hv_CameraParam.TupleSelect(hv_I));
                }
                else
                {
                    throw new HalconException("Unknown camera parameter " + hv_ParamNameInd);
                }
            }

            return;
        }

        // Chapter: Calibration / Camera Parameters
        // Short Description: Get the names of the parameters in a camera parameter tuple. 
        public void get_cam_par_names(HTuple hv_CameraParam, out HTuple hv_CameraType,
            out HTuple hv_ParamNames)
        {



            // Local iconic variables 

            // Local control variables 

            HTuple hv_CameraParamAreaScanDivision = null;
            HTuple hv_CameraParamAreaScanPolynomial = null, hv_CameraParamAreaScanTelecentricDivision = null;
            HTuple hv_CameraParamAreaScanTelecentricPolynomial = null;
            HTuple hv_CameraParamAreaScanTiltDivision = null, hv_CameraParamAreaScanTiltPolynomial = null;
            HTuple hv_CameraParamAreaScanImageSideTelecentricTiltDivision = null;
            HTuple hv_CameraParamAreaScanImageSideTelecentricTiltPolynomial = null;
            HTuple hv_CameraParamAreaScanBilateralTelecentricTiltDivision = null;
            HTuple hv_CameraParamAreaScanBilateralTelecentricTiltPolynomial = null;
            HTuple hv_CameraParamAreaScanObjectSideTelecentricTiltDivision = null;
            HTuple hv_CameraParamAreaScanObjectSideTelecentricTiltPolynomial = null;
            HTuple hv_CameraParamLinesScan = null, hv_CameraParamAreaScanTiltDivisionLegacy = null;
            HTuple hv_CameraParamAreaScanTiltPolynomialLegacy = null;
            HTuple hv_CameraParamAreaScanTelecentricDivisionLegacy = null;
            HTuple hv_CameraParamAreaScanTelecentricPolynomialLegacy = null;
            HTuple hv_CameraParamAreaScanBilateralTelecentricTiltDivisionLegacy = null;
            HTuple hv_CameraParamAreaScanBilateralTelecentricTiltPolynomialLegacy = null;
            // Initialize local and output iconic variables 
            hv_CameraType = new HTuple();
            hv_ParamNames = new HTuple();
            //get_cam_par_names returns for each element in the camera
            //parameter tuple that is passed in CameraParam the name
            //of the respective camera parameter. The parameter names
            //are returned in ParamNames. Additionally, the camera
            //type is returned in CameraType. Alternatively, instead of
            //the camera parameters, the camera type can be passed in
            //CameraParam in form of one of the following strings:
            //  - 'area_scan_division'
            //  - 'area_scan_polynomial'
            //  - 'area_scan_tilt_division'
            //  - 'area_scan_tilt_polynomial'
            //  - 'area_scan_telecentric_division'
            //  - 'area_scan_telecentric_polynomial'
            //  - 'area_scan_tilt_bilateral_telecentric_division'
            //  - 'area_scan_tilt_bilateral_telecentric_polynomial'
            //  - 'area_scan_tilt_object_side_telecentric_division'
            //  - 'area_scan_tilt_object_side_telecentric_polynomial'
            //  - 'line_scan'
            //
            hv_CameraParamAreaScanDivision = new HTuple();
            hv_CameraParamAreaScanDivision[0] = "focus";
            hv_CameraParamAreaScanDivision[1] = "kappa";
            hv_CameraParamAreaScanDivision[2] = "sx";
            hv_CameraParamAreaScanDivision[3] = "sy";
            hv_CameraParamAreaScanDivision[4] = "cx";
            hv_CameraParamAreaScanDivision[5] = "cy";
            hv_CameraParamAreaScanDivision[6] = "image_width";
            hv_CameraParamAreaScanDivision[7] = "image_height";
            hv_CameraParamAreaScanPolynomial = new HTuple();
            hv_CameraParamAreaScanPolynomial[0] = "focus";
            hv_CameraParamAreaScanPolynomial[1] = "k1";
            hv_CameraParamAreaScanPolynomial[2] = "k2";
            hv_CameraParamAreaScanPolynomial[3] = "k3";
            hv_CameraParamAreaScanPolynomial[4] = "p1";
            hv_CameraParamAreaScanPolynomial[5] = "p2";
            hv_CameraParamAreaScanPolynomial[6] = "sx";
            hv_CameraParamAreaScanPolynomial[7] = "sy";
            hv_CameraParamAreaScanPolynomial[8] = "cx";
            hv_CameraParamAreaScanPolynomial[9] = "cy";
            hv_CameraParamAreaScanPolynomial[10] = "image_width";
            hv_CameraParamAreaScanPolynomial[11] = "image_height";
            hv_CameraParamAreaScanTelecentricDivision = new HTuple();
            hv_CameraParamAreaScanTelecentricDivision[0] = "magnification";
            hv_CameraParamAreaScanTelecentricDivision[1] = "kappa";
            hv_CameraParamAreaScanTelecentricDivision[2] = "sx";
            hv_CameraParamAreaScanTelecentricDivision[3] = "sy";
            hv_CameraParamAreaScanTelecentricDivision[4] = "cx";
            hv_CameraParamAreaScanTelecentricDivision[5] = "cy";
            hv_CameraParamAreaScanTelecentricDivision[6] = "image_width";
            hv_CameraParamAreaScanTelecentricDivision[7] = "image_height";
            hv_CameraParamAreaScanTelecentricPolynomial = new HTuple();
            hv_CameraParamAreaScanTelecentricPolynomial[0] = "magnification";
            hv_CameraParamAreaScanTelecentricPolynomial[1] = "k1";
            hv_CameraParamAreaScanTelecentricPolynomial[2] = "k2";
            hv_CameraParamAreaScanTelecentricPolynomial[3] = "k3";
            hv_CameraParamAreaScanTelecentricPolynomial[4] = "p1";
            hv_CameraParamAreaScanTelecentricPolynomial[5] = "p2";
            hv_CameraParamAreaScanTelecentricPolynomial[6] = "sx";
            hv_CameraParamAreaScanTelecentricPolynomial[7] = "sy";
            hv_CameraParamAreaScanTelecentricPolynomial[8] = "cx";
            hv_CameraParamAreaScanTelecentricPolynomial[9] = "cy";
            hv_CameraParamAreaScanTelecentricPolynomial[10] = "image_width";
            hv_CameraParamAreaScanTelecentricPolynomial[11] = "image_height";
            hv_CameraParamAreaScanTiltDivision = new HTuple();
            hv_CameraParamAreaScanTiltDivision[0] = "focus";
            hv_CameraParamAreaScanTiltDivision[1] = "kappa";
            hv_CameraParamAreaScanTiltDivision[2] = "image_plane_dist";
            hv_CameraParamAreaScanTiltDivision[3] = "tilt";
            hv_CameraParamAreaScanTiltDivision[4] = "rot";
            hv_CameraParamAreaScanTiltDivision[5] = "sx";
            hv_CameraParamAreaScanTiltDivision[6] = "sy";
            hv_CameraParamAreaScanTiltDivision[7] = "cx";
            hv_CameraParamAreaScanTiltDivision[8] = "cy";
            hv_CameraParamAreaScanTiltDivision[9] = "image_width";
            hv_CameraParamAreaScanTiltDivision[10] = "image_height";
            hv_CameraParamAreaScanTiltPolynomial = new HTuple();
            hv_CameraParamAreaScanTiltPolynomial[0] = "focus";
            hv_CameraParamAreaScanTiltPolynomial[1] = "k1";
            hv_CameraParamAreaScanTiltPolynomial[2] = "k2";
            hv_CameraParamAreaScanTiltPolynomial[3] = "k3";
            hv_CameraParamAreaScanTiltPolynomial[4] = "p1";
            hv_CameraParamAreaScanTiltPolynomial[5] = "p2";
            hv_CameraParamAreaScanTiltPolynomial[6] = "image_plane_dist";
            hv_CameraParamAreaScanTiltPolynomial[7] = "tilt";
            hv_CameraParamAreaScanTiltPolynomial[8] = "rot";
            hv_CameraParamAreaScanTiltPolynomial[9] = "sx";
            hv_CameraParamAreaScanTiltPolynomial[10] = "sy";
            hv_CameraParamAreaScanTiltPolynomial[11] = "cx";
            hv_CameraParamAreaScanTiltPolynomial[12] = "cy";
            hv_CameraParamAreaScanTiltPolynomial[13] = "image_width";
            hv_CameraParamAreaScanTiltPolynomial[14] = "image_height";
            hv_CameraParamAreaScanImageSideTelecentricTiltDivision = new HTuple();
            hv_CameraParamAreaScanImageSideTelecentricTiltDivision[0] = "focus";
            hv_CameraParamAreaScanImageSideTelecentricTiltDivision[1] = "kappa";
            hv_CameraParamAreaScanImageSideTelecentricTiltDivision[2] = "tilt";
            hv_CameraParamAreaScanImageSideTelecentricTiltDivision[3] = "rot";
            hv_CameraParamAreaScanImageSideTelecentricTiltDivision[4] = "sx";
            hv_CameraParamAreaScanImageSideTelecentricTiltDivision[5] = "sy";
            hv_CameraParamAreaScanImageSideTelecentricTiltDivision[6] = "cx";
            hv_CameraParamAreaScanImageSideTelecentricTiltDivision[7] = "cy";
            hv_CameraParamAreaScanImageSideTelecentricTiltDivision[8] = "image_width";
            hv_CameraParamAreaScanImageSideTelecentricTiltDivision[9] = "image_height";
            hv_CameraParamAreaScanImageSideTelecentricTiltPolynomial = new HTuple();
            hv_CameraParamAreaScanImageSideTelecentricTiltPolynomial[0] = "focus";
            hv_CameraParamAreaScanImageSideTelecentricTiltPolynomial[1] = "k1";
            hv_CameraParamAreaScanImageSideTelecentricTiltPolynomial[2] = "k2";
            hv_CameraParamAreaScanImageSideTelecentricTiltPolynomial[3] = "k3";
            hv_CameraParamAreaScanImageSideTelecentricTiltPolynomial[4] = "p1";
            hv_CameraParamAreaScanImageSideTelecentricTiltPolynomial[5] = "p2";
            hv_CameraParamAreaScanImageSideTelecentricTiltPolynomial[6] = "tilt";
            hv_CameraParamAreaScanImageSideTelecentricTiltPolynomial[7] = "rot";
            hv_CameraParamAreaScanImageSideTelecentricTiltPolynomial[8] = "sx";
            hv_CameraParamAreaScanImageSideTelecentricTiltPolynomial[9] = "sy";
            hv_CameraParamAreaScanImageSideTelecentricTiltPolynomial[10] = "cx";
            hv_CameraParamAreaScanImageSideTelecentricTiltPolynomial[11] = "cy";
            hv_CameraParamAreaScanImageSideTelecentricTiltPolynomial[12] = "image_width";
            hv_CameraParamAreaScanImageSideTelecentricTiltPolynomial[13] = "image_height";
            hv_CameraParamAreaScanBilateralTelecentricTiltDivision = new HTuple();
            hv_CameraParamAreaScanBilateralTelecentricTiltDivision[0] = "magnification";
            hv_CameraParamAreaScanBilateralTelecentricTiltDivision[1] = "kappa";
            hv_CameraParamAreaScanBilateralTelecentricTiltDivision[2] = "tilt";
            hv_CameraParamAreaScanBilateralTelecentricTiltDivision[3] = "rot";
            hv_CameraParamAreaScanBilateralTelecentricTiltDivision[4] = "sx";
            hv_CameraParamAreaScanBilateralTelecentricTiltDivision[5] = "sy";
            hv_CameraParamAreaScanBilateralTelecentricTiltDivision[6] = "cx";
            hv_CameraParamAreaScanBilateralTelecentricTiltDivision[7] = "cy";
            hv_CameraParamAreaScanBilateralTelecentricTiltDivision[8] = "image_width";
            hv_CameraParamAreaScanBilateralTelecentricTiltDivision[9] = "image_height";
            hv_CameraParamAreaScanBilateralTelecentricTiltPolynomial = new HTuple();
            hv_CameraParamAreaScanBilateralTelecentricTiltPolynomial[0] = "magnification";
            hv_CameraParamAreaScanBilateralTelecentricTiltPolynomial[1] = "k1";
            hv_CameraParamAreaScanBilateralTelecentricTiltPolynomial[2] = "k2";
            hv_CameraParamAreaScanBilateralTelecentricTiltPolynomial[3] = "k3";
            hv_CameraParamAreaScanBilateralTelecentricTiltPolynomial[4] = "p1";
            hv_CameraParamAreaScanBilateralTelecentricTiltPolynomial[5] = "p2";
            hv_CameraParamAreaScanBilateralTelecentricTiltPolynomial[6] = "tilt";
            hv_CameraParamAreaScanBilateralTelecentricTiltPolynomial[7] = "rot";
            hv_CameraParamAreaScanBilateralTelecentricTiltPolynomial[8] = "sx";
            hv_CameraParamAreaScanBilateralTelecentricTiltPolynomial[9] = "sy";
            hv_CameraParamAreaScanBilateralTelecentricTiltPolynomial[10] = "cx";
            hv_CameraParamAreaScanBilateralTelecentricTiltPolynomial[11] = "cy";
            hv_CameraParamAreaScanBilateralTelecentricTiltPolynomial[12] = "image_width";
            hv_CameraParamAreaScanBilateralTelecentricTiltPolynomial[13] = "image_height";
            hv_CameraParamAreaScanObjectSideTelecentricTiltDivision = new HTuple();
            hv_CameraParamAreaScanObjectSideTelecentricTiltDivision[0] = "magnification";
            hv_CameraParamAreaScanObjectSideTelecentricTiltDivision[1] = "kappa";
            hv_CameraParamAreaScanObjectSideTelecentricTiltDivision[2] = "image_plane_dist";
            hv_CameraParamAreaScanObjectSideTelecentricTiltDivision[3] = "tilt";
            hv_CameraParamAreaScanObjectSideTelecentricTiltDivision[4] = "rot";
            hv_CameraParamAreaScanObjectSideTelecentricTiltDivision[5] = "sx";
            hv_CameraParamAreaScanObjectSideTelecentricTiltDivision[6] = "sy";
            hv_CameraParamAreaScanObjectSideTelecentricTiltDivision[7] = "cx";
            hv_CameraParamAreaScanObjectSideTelecentricTiltDivision[8] = "cy";
            hv_CameraParamAreaScanObjectSideTelecentricTiltDivision[9] = "image_width";
            hv_CameraParamAreaScanObjectSideTelecentricTiltDivision[10] = "image_height";
            hv_CameraParamAreaScanObjectSideTelecentricTiltPolynomial = new HTuple();
            hv_CameraParamAreaScanObjectSideTelecentricTiltPolynomial[0] = "magnification";
            hv_CameraParamAreaScanObjectSideTelecentricTiltPolynomial[1] = "k1";
            hv_CameraParamAreaScanObjectSideTelecentricTiltPolynomial[2] = "k2";
            hv_CameraParamAreaScanObjectSideTelecentricTiltPolynomial[3] = "k3";
            hv_CameraParamAreaScanObjectSideTelecentricTiltPolynomial[4] = "p1";
            hv_CameraParamAreaScanObjectSideTelecentricTiltPolynomial[5] = "p2";
            hv_CameraParamAreaScanObjectSideTelecentricTiltPolynomial[6] = "image_plane_dist";
            hv_CameraParamAreaScanObjectSideTelecentricTiltPolynomial[7] = "tilt";
            hv_CameraParamAreaScanObjectSideTelecentricTiltPolynomial[8] = "rot";
            hv_CameraParamAreaScanObjectSideTelecentricTiltPolynomial[9] = "sx";
            hv_CameraParamAreaScanObjectSideTelecentricTiltPolynomial[10] = "sy";
            hv_CameraParamAreaScanObjectSideTelecentricTiltPolynomial[11] = "cx";
            hv_CameraParamAreaScanObjectSideTelecentricTiltPolynomial[12] = "cy";
            hv_CameraParamAreaScanObjectSideTelecentricTiltPolynomial[13] = "image_width";
            hv_CameraParamAreaScanObjectSideTelecentricTiltPolynomial[14] = "image_height";
            hv_CameraParamLinesScan = new HTuple();
            hv_CameraParamLinesScan[0] = "focus";
            hv_CameraParamLinesScan[1] = "kappa";
            hv_CameraParamLinesScan[2] = "sx";
            hv_CameraParamLinesScan[3] = "sy";
            hv_CameraParamLinesScan[4] = "cx";
            hv_CameraParamLinesScan[5] = "cy";
            hv_CameraParamLinesScan[6] = "image_width";
            hv_CameraParamLinesScan[7] = "image_height";
            hv_CameraParamLinesScan[8] = "vx";
            hv_CameraParamLinesScan[9] = "vy";
            hv_CameraParamLinesScan[10] = "vz";
            //Legacy parameter names
            hv_CameraParamAreaScanTiltDivisionLegacy = new HTuple();
            hv_CameraParamAreaScanTiltDivisionLegacy[0] = "focus";
            hv_CameraParamAreaScanTiltDivisionLegacy[1] = "kappa";
            hv_CameraParamAreaScanTiltDivisionLegacy[2] = "tilt";
            hv_CameraParamAreaScanTiltDivisionLegacy[3] = "rot";
            hv_CameraParamAreaScanTiltDivisionLegacy[4] = "sx";
            hv_CameraParamAreaScanTiltDivisionLegacy[5] = "sy";
            hv_CameraParamAreaScanTiltDivisionLegacy[6] = "cx";
            hv_CameraParamAreaScanTiltDivisionLegacy[7] = "cy";
            hv_CameraParamAreaScanTiltDivisionLegacy[8] = "image_width";
            hv_CameraParamAreaScanTiltDivisionLegacy[9] = "image_height";
            hv_CameraParamAreaScanTiltPolynomialLegacy = new HTuple();
            hv_CameraParamAreaScanTiltPolynomialLegacy[0] = "focus";
            hv_CameraParamAreaScanTiltPolynomialLegacy[1] = "k1";
            hv_CameraParamAreaScanTiltPolynomialLegacy[2] = "k2";
            hv_CameraParamAreaScanTiltPolynomialLegacy[3] = "k3";
            hv_CameraParamAreaScanTiltPolynomialLegacy[4] = "p1";
            hv_CameraParamAreaScanTiltPolynomialLegacy[5] = "p2";
            hv_CameraParamAreaScanTiltPolynomialLegacy[6] = "tilt";
            hv_CameraParamAreaScanTiltPolynomialLegacy[7] = "rot";
            hv_CameraParamAreaScanTiltPolynomialLegacy[8] = "sx";
            hv_CameraParamAreaScanTiltPolynomialLegacy[9] = "sy";
            hv_CameraParamAreaScanTiltPolynomialLegacy[10] = "cx";
            hv_CameraParamAreaScanTiltPolynomialLegacy[11] = "cy";
            hv_CameraParamAreaScanTiltPolynomialLegacy[12] = "image_width";
            hv_CameraParamAreaScanTiltPolynomialLegacy[13] = "image_height";
            hv_CameraParamAreaScanTelecentricDivisionLegacy = new HTuple();
            hv_CameraParamAreaScanTelecentricDivisionLegacy[0] = "focus";
            hv_CameraParamAreaScanTelecentricDivisionLegacy[1] = "kappa";
            hv_CameraParamAreaScanTelecentricDivisionLegacy[2] = "sx";
            hv_CameraParamAreaScanTelecentricDivisionLegacy[3] = "sy";
            hv_CameraParamAreaScanTelecentricDivisionLegacy[4] = "cx";
            hv_CameraParamAreaScanTelecentricDivisionLegacy[5] = "cy";
            hv_CameraParamAreaScanTelecentricDivisionLegacy[6] = "image_width";
            hv_CameraParamAreaScanTelecentricDivisionLegacy[7] = "image_height";
            hv_CameraParamAreaScanTelecentricPolynomialLegacy = new HTuple();
            hv_CameraParamAreaScanTelecentricPolynomialLegacy[0] = "focus";
            hv_CameraParamAreaScanTelecentricPolynomialLegacy[1] = "k1";
            hv_CameraParamAreaScanTelecentricPolynomialLegacy[2] = "k2";
            hv_CameraParamAreaScanTelecentricPolynomialLegacy[3] = "k3";
            hv_CameraParamAreaScanTelecentricPolynomialLegacy[4] = "p1";
            hv_CameraParamAreaScanTelecentricPolynomialLegacy[5] = "p2";
            hv_CameraParamAreaScanTelecentricPolynomialLegacy[6] = "sx";
            hv_CameraParamAreaScanTelecentricPolynomialLegacy[7] = "sy";
            hv_CameraParamAreaScanTelecentricPolynomialLegacy[8] = "cx";
            hv_CameraParamAreaScanTelecentricPolynomialLegacy[9] = "cy";
            hv_CameraParamAreaScanTelecentricPolynomialLegacy[10] = "image_width";
            hv_CameraParamAreaScanTelecentricPolynomialLegacy[11] = "image_height";
            hv_CameraParamAreaScanBilateralTelecentricTiltDivisionLegacy = new HTuple();
            hv_CameraParamAreaScanBilateralTelecentricTiltDivisionLegacy[0] = "focus";
            hv_CameraParamAreaScanBilateralTelecentricTiltDivisionLegacy[1] = "kappa";
            hv_CameraParamAreaScanBilateralTelecentricTiltDivisionLegacy[2] = "tilt";
            hv_CameraParamAreaScanBilateralTelecentricTiltDivisionLegacy[3] = "rot";
            hv_CameraParamAreaScanBilateralTelecentricTiltDivisionLegacy[4] = "sx";
            hv_CameraParamAreaScanBilateralTelecentricTiltDivisionLegacy[5] = "sy";
            hv_CameraParamAreaScanBilateralTelecentricTiltDivisionLegacy[6] = "cx";
            hv_CameraParamAreaScanBilateralTelecentricTiltDivisionLegacy[7] = "cy";
            hv_CameraParamAreaScanBilateralTelecentricTiltDivisionLegacy[8] = "image_width";
            hv_CameraParamAreaScanBilateralTelecentricTiltDivisionLegacy[9] = "image_height";
            hv_CameraParamAreaScanBilateralTelecentricTiltPolynomialLegacy = new HTuple();
            hv_CameraParamAreaScanBilateralTelecentricTiltPolynomialLegacy[0] = "focus";
            hv_CameraParamAreaScanBilateralTelecentricTiltPolynomialLegacy[1] = "k1";
            hv_CameraParamAreaScanBilateralTelecentricTiltPolynomialLegacy[2] = "k2";
            hv_CameraParamAreaScanBilateralTelecentricTiltPolynomialLegacy[3] = "k3";
            hv_CameraParamAreaScanBilateralTelecentricTiltPolynomialLegacy[4] = "p1";
            hv_CameraParamAreaScanBilateralTelecentricTiltPolynomialLegacy[5] = "p2";
            hv_CameraParamAreaScanBilateralTelecentricTiltPolynomialLegacy[6] = "tilt";
            hv_CameraParamAreaScanBilateralTelecentricTiltPolynomialLegacy[7] = "rot";
            hv_CameraParamAreaScanBilateralTelecentricTiltPolynomialLegacy[8] = "sx";
            hv_CameraParamAreaScanBilateralTelecentricTiltPolynomialLegacy[9] = "sy";
            hv_CameraParamAreaScanBilateralTelecentricTiltPolynomialLegacy[10] = "cx";
            hv_CameraParamAreaScanBilateralTelecentricTiltPolynomialLegacy[11] = "cy";
            hv_CameraParamAreaScanBilateralTelecentricTiltPolynomialLegacy[12] = "image_width";
            hv_CameraParamAreaScanBilateralTelecentricTiltPolynomialLegacy[13] = "image_height";
            //
            //If the camera type is passed in CameraParam
            if ((int)new HTuple(new HTuple(hv_CameraParam.TupleLength()).TupleEqual(1)).TupleAnd(
                hv_CameraParam.TupleSelect(0).TupleIsString()) != 0)
            {
                hv_CameraType = hv_CameraParam.TupleSelect(0);
                if ((int)new HTuple(hv_CameraType.TupleEqual("area_scan_division")) != 0)
                {
                    hv_ParamNames = new HTuple();
                    hv_ParamNames[0] = "camera_type";
                    hv_ParamNames = hv_ParamNames.TupleConcat(hv_CameraParamAreaScanDivision);
                }
                else if ((int)new HTuple(hv_CameraType.TupleEqual("area_scan_polynomial")) != 0)
                {
                    hv_ParamNames = new HTuple();
                    hv_ParamNames[0] = "camera_type";
                    hv_ParamNames = hv_ParamNames.TupleConcat(hv_CameraParamAreaScanPolynomial);
                }
                else if ((int)new HTuple(hv_CameraType.TupleEqual("area_scan_telecentric_division")) != 0)
                {
                    hv_ParamNames = new HTuple();
                    hv_ParamNames[0] = "camera_type";
                    hv_ParamNames = hv_ParamNames.TupleConcat(hv_CameraParamAreaScanTelecentricDivision);
                }
                else if ((int)new HTuple(hv_CameraType.TupleEqual("area_scan_telecentric_polynomial")) != 0)
                {
                    hv_ParamNames = new HTuple();
                    hv_ParamNames[0] = "camera_type";
                    hv_ParamNames = hv_ParamNames.TupleConcat(hv_CameraParamAreaScanTelecentricPolynomial);
                }
                else if ((int)new HTuple(hv_CameraType.TupleEqual("area_scan_tilt_division")) != 0)
                {
                    hv_ParamNames = new HTuple();
                    hv_ParamNames[0] = "camera_type";
                    hv_ParamNames = hv_ParamNames.TupleConcat(hv_CameraParamAreaScanTiltDivision);
                }
                else if ((int)new HTuple(hv_CameraType.TupleEqual("area_scan_tilt_polynomial")) != 0)
                {
                    hv_ParamNames = new HTuple();
                    hv_ParamNames[0] = "camera_type";
                    hv_ParamNames = hv_ParamNames.TupleConcat(hv_CameraParamAreaScanTiltPolynomial);
                }
                else if ((int)new HTuple(hv_CameraType.TupleEqual("area_scan_tilt_image_side_telecentric_division")) != 0)
                {
                    hv_ParamNames = new HTuple();
                    hv_ParamNames[0] = "camera_type";
                    hv_ParamNames = hv_ParamNames.TupleConcat(hv_CameraParamAreaScanImageSideTelecentricTiltDivision);
                }
                else if ((int)new HTuple(hv_CameraType.TupleEqual("area_scan_tilt_image_side_telecentric_polynomial")) != 0)
                {
                    hv_ParamNames = new HTuple();
                    hv_ParamNames[0] = "camera_type";
                    hv_ParamNames = hv_ParamNames.TupleConcat(hv_CameraParamAreaScanImageSideTelecentricTiltPolynomial);
                }
                else if ((int)new HTuple(hv_CameraType.TupleEqual("area_scan_tilt_bilateral_telecentric_division")) != 0)
                {
                    hv_ParamNames = new HTuple();
                    hv_ParamNames[0] = "camera_type";
                    hv_ParamNames = hv_ParamNames.TupleConcat(hv_CameraParamAreaScanBilateralTelecentricTiltDivision);
                }
                else if ((int)new HTuple(hv_CameraType.TupleEqual("area_scan_tilt_bilateral_telecentric_polynomial")) != 0)
                {
                    hv_ParamNames = new HTuple();
                    hv_ParamNames[0] = "camera_type";
                    hv_ParamNames = hv_ParamNames.TupleConcat(hv_CameraParamAreaScanBilateralTelecentricTiltPolynomial);
                }
                else if ((int)new HTuple(hv_CameraType.TupleEqual("area_scan_tilt_object_side_telecentric_division")) != 0)
                {
                    hv_ParamNames = new HTuple();
                    hv_ParamNames[0] = "camera_type";
                    hv_ParamNames = hv_ParamNames.TupleConcat(hv_CameraParamAreaScanObjectSideTelecentricTiltDivision);
                }
                else if ((int)new HTuple(hv_CameraType.TupleEqual("area_scan_tilt_object_side_telecentric_polynomial")) != 0)
                {
                    hv_ParamNames = new HTuple();
                    hv_ParamNames[0] = "camera_type";
                    hv_ParamNames = hv_ParamNames.TupleConcat(hv_CameraParamAreaScanObjectSideTelecentricTiltPolynomial);
                }
                else if ((int)new HTuple(hv_CameraType.TupleEqual("line_scan")) != 0)
                {
                    hv_ParamNames = new HTuple();
                    hv_ParamNames[0] = "camera_type";
                    hv_ParamNames = hv_ParamNames.TupleConcat(hv_CameraParamLinesScan);
                }
                else
                {
                    throw new HalconException("Unknown camera type '" + hv_CameraType + "' passed in CameraParam.");
                }

                return;
            }
            //
            //If the camera parameters are passed in CameraParam
            if ((int)hv_CameraParam.TupleSelect(0).TupleIsString().TupleNot() != 0)
            {
                //Format of camera parameters for HALCON 12 and earlier
                switch (new HTuple(hv_CameraParam.TupleLength()
                    ).I)
                {
                    //
                    //Area Scan
                    case 8:
                        //CameraType: 'area_scan_division' or 'area_scan_telecentric_division'
                        if ((int)new HTuple(hv_CameraParam.TupleSelect(0).TupleNotEqual(0.0)) != 0)
                        {
                            hv_ParamNames = hv_CameraParamAreaScanDivision.Clone();
                            hv_CameraType = "area_scan_division";
                        }
                        else
                        {
                            hv_ParamNames = hv_CameraParamAreaScanTelecentricDivisionLegacy.Clone();
                            hv_CameraType = "area_scan_telecentric_division";
                        }
                        break;
                    case 10:
                        //CameraType: 'area_scan_tilt_division' or 'area_scan_telecentric_tilt_division'
                        if ((int)new HTuple(hv_CameraParam.TupleSelect(0).TupleNotEqual(0.0)) != 0)
                        {
                            hv_ParamNames = hv_CameraParamAreaScanTiltDivisionLegacy.Clone();
                            hv_CameraType = "area_scan_tilt_division";
                        }
                        else
                        {
                            hv_ParamNames = hv_CameraParamAreaScanBilateralTelecentricTiltDivisionLegacy.Clone();
                            hv_CameraType = "area_scan_tilt_bilateral_telecentric_division";
                        }
                        break;
                    case 12:
                        //CameraType: 'area_scan_polynomial' or 'area_scan_telecentric_polynomial'
                        if ((int)new HTuple(hv_CameraParam.TupleSelect(0).TupleNotEqual(0.0)) != 0)
                        {
                            hv_ParamNames = hv_CameraParamAreaScanPolynomial.Clone();
                            hv_CameraType = "area_scan_polynomial";
                        }
                        else
                        {
                            hv_ParamNames = hv_CameraParamAreaScanTelecentricPolynomialLegacy.Clone();
                            hv_CameraType = "area_scan_telecentric_polynomial";
                        }
                        break;
                    case 14:
                        //CameraType: 'area_scan_tilt_polynomial' or 'area_scan_telecentric_tilt_polynomial'
                        if ((int)new HTuple(hv_CameraParam.TupleSelect(0).TupleNotEqual(0.0)) != 0)
                        {
                            hv_ParamNames = hv_CameraParamAreaScanTiltPolynomialLegacy.Clone();
                            hv_CameraType = "area_scan_tilt_polynomial";
                        }
                        else
                        {
                            hv_ParamNames = hv_CameraParamAreaScanBilateralTelecentricTiltPolynomialLegacy.Clone();
                            hv_CameraType = "area_scan_tilt_bilateral_telecentric_polynomial";
                        }
                        break;
                    //
                    //Line Scan
                    case 11:
                        //CameraType: 'line_scan'
                        hv_ParamNames = hv_CameraParamLinesScan.Clone();
                        hv_CameraType = "line_scan";
                        break;
                    default:
                        throw new HalconException("Wrong number of values in CameraParam.");
                }
            }
            else
            {
                //Format of camera parameters since HALCON 13
                hv_CameraType = hv_CameraParam.TupleSelect(0);
                if ((int)new HTuple(hv_CameraType.TupleEqual("area_scan_division")) != 0)
                {
                    if ((int)new HTuple(new HTuple(hv_CameraParam.TupleLength()).TupleNotEqual(
                        9)) != 0)
                    {
                        throw new HalconException("Wrong number of values in CameraParam.");
                    }
                    hv_ParamNames = new HTuple();
                    hv_ParamNames[0] = "camera_type";
                    hv_ParamNames = hv_ParamNames.TupleConcat(hv_CameraParamAreaScanDivision);
                }
                else if ((int)new HTuple(hv_CameraType.TupleEqual("area_scan_polynomial")) != 0)
                {
                    if ((int)new HTuple(new HTuple(hv_CameraParam.TupleLength()).TupleNotEqual(
                        13)) != 0)
                    {
                        throw new HalconException("Wrong number of values in CameraParam.");
                    }
                    hv_ParamNames = new HTuple();
                    hv_ParamNames[0] = "camera_type";
                    hv_ParamNames = hv_ParamNames.TupleConcat(hv_CameraParamAreaScanPolynomial);
                }
                else if ((int)new HTuple(hv_CameraType.TupleEqual("area_scan_telecentric_division")) != 0)
                {
                    if ((int)new HTuple(new HTuple(hv_CameraParam.TupleLength()).TupleNotEqual(
                        9)) != 0)
                    {
                        throw new HalconException("Wrong number of values in CameraParam.");
                    }
                    hv_ParamNames = new HTuple();
                    hv_ParamNames[0] = "camera_type";
                    hv_ParamNames = hv_ParamNames.TupleConcat(hv_CameraParamAreaScanTelecentricDivision);
                }
                else if ((int)new HTuple(hv_CameraType.TupleEqual("area_scan_telecentric_polynomial")) != 0)
                {
                    if ((int)new HTuple(new HTuple(hv_CameraParam.TupleLength()).TupleNotEqual(
                        13)) != 0)
                    {
                        throw new HalconException("Wrong number of values in CameraParam.");
                    }
                    hv_ParamNames = new HTuple();
                    hv_ParamNames[0] = "camera_type";
                    hv_ParamNames = hv_ParamNames.TupleConcat(hv_CameraParamAreaScanTelecentricPolynomial);
                }
                else if ((int)new HTuple(hv_CameraType.TupleEqual("area_scan_tilt_division")) != 0)
                {
                    if ((int)new HTuple(new HTuple(hv_CameraParam.TupleLength()).TupleNotEqual(
                        12)) != 0)
                    {
                        throw new HalconException("Wrong number of values in CameraParam.");
                    }
                    hv_ParamNames = new HTuple();
                    hv_ParamNames[0] = "camera_type";
                    hv_ParamNames = hv_ParamNames.TupleConcat(hv_CameraParamAreaScanTiltDivision);
                }
                else if ((int)new HTuple(hv_CameraType.TupleEqual("area_scan_tilt_polynomial")) != 0)
                {
                    if ((int)new HTuple(new HTuple(hv_CameraParam.TupleLength()).TupleNotEqual(
                        16)) != 0)
                    {
                        throw new HalconException("Wrong number of values in CameraParam.");
                    }
                    hv_ParamNames = new HTuple();
                    hv_ParamNames[0] = "camera_type";
                    hv_ParamNames = hv_ParamNames.TupleConcat(hv_CameraParamAreaScanTiltPolynomial);
                }
                else if ((int)new HTuple(hv_CameraType.TupleEqual("area_scan_tilt_image_side_telecentric_division")) != 0)
                {
                    if ((int)new HTuple(new HTuple(hv_CameraParam.TupleLength()).TupleNotEqual(
                        11)) != 0)
                    {
                        throw new HalconException("Wrong number of values in CameraParam.");
                    }
                    hv_ParamNames = new HTuple();
                    hv_ParamNames[0] = "camera_type";
                    hv_ParamNames = hv_ParamNames.TupleConcat(hv_CameraParamAreaScanImageSideTelecentricTiltDivision);
                }
                else if ((int)new HTuple(hv_CameraType.TupleEqual("area_scan_tilt_image_side_telecentric_polynomial")) != 0)
                {
                    if ((int)new HTuple(new HTuple(hv_CameraParam.TupleLength()).TupleNotEqual(
                        15)) != 0)
                    {
                        throw new HalconException("Wrong number of values in CameraParam.");
                    }
                    hv_ParamNames = new HTuple();
                    hv_ParamNames[0] = "camera_type";
                    hv_ParamNames = hv_ParamNames.TupleConcat(hv_CameraParamAreaScanImageSideTelecentricTiltPolynomial);
                }
                else if ((int)new HTuple(hv_CameraType.TupleEqual("area_scan_tilt_bilateral_telecentric_division")) != 0)
                {
                    if ((int)new HTuple(new HTuple(hv_CameraParam.TupleLength()).TupleNotEqual(
                        11)) != 0)
                    {
                        throw new HalconException("Wrong number of values in CameraParam.");
                    }
                    hv_ParamNames = new HTuple();
                    hv_ParamNames[0] = "camera_type";
                    hv_ParamNames = hv_ParamNames.TupleConcat(hv_CameraParamAreaScanBilateralTelecentricTiltDivision);
                }
                else if ((int)new HTuple(hv_CameraType.TupleEqual("area_scan_tilt_bilateral_telecentric_polynomial")) != 0)
                {
                    if ((int)new HTuple(new HTuple(hv_CameraParam.TupleLength()).TupleNotEqual(
                        15)) != 0)
                    {
                        throw new HalconException("Wrong number of values in CameraParam.");
                    }
                    hv_ParamNames = new HTuple();
                    hv_ParamNames[0] = "camera_type";
                    hv_ParamNames = hv_ParamNames.TupleConcat(hv_CameraParamAreaScanBilateralTelecentricTiltPolynomial);
                }
                else if ((int)new HTuple(hv_CameraType.TupleEqual("area_scan_tilt_object_side_telecentric_division")) != 0)
                {
                    if ((int)new HTuple(new HTuple(hv_CameraParam.TupleLength()).TupleNotEqual(
                        12)) != 0)
                    {
                        throw new HalconException("Wrong number of values in CameraParam.");
                    }
                    hv_ParamNames = new HTuple();
                    hv_ParamNames[0] = "camera_type";
                    hv_ParamNames = hv_ParamNames.TupleConcat(hv_CameraParamAreaScanObjectSideTelecentricTiltDivision);
                }
                else if ((int)new HTuple(hv_CameraType.TupleEqual("area_scan_tilt_object_side_telecentric_polynomial")) != 0)
                {
                    if ((int)new HTuple(new HTuple(hv_CameraParam.TupleLength()).TupleNotEqual(
                        16)) != 0)
                    {
                        throw new HalconException("Wrong number of values in CameraParam.");
                    }
                    hv_ParamNames = new HTuple();
                    hv_ParamNames[0] = "camera_type";
                    hv_ParamNames = hv_ParamNames.TupleConcat(hv_CameraParamAreaScanObjectSideTelecentricTiltPolynomial);
                }
                else if ((int)new HTuple(hv_CameraType.TupleEqual("line_scan")) != 0)
                {
                    if ((int)new HTuple(new HTuple(hv_CameraParam.TupleLength()).TupleNotEqual(
                        12)) != 0)
                    {
                        throw new HalconException("Wrong number of values in CameraParam.");
                    }
                    hv_ParamNames = new HTuple();
                    hv_ParamNames[0] = "camera_type";
                    hv_ParamNames = hv_ParamNames.TupleConcat(hv_CameraParamLinesScan);
                }
                else
                {
                    throw new HalconException("Unknown camera type in CameraParam.");
                }
            }

            return;
        }

        // Chapter: Calibration / Camera Parameters
        // Short Description: Set the value of a specified camera parameter in the camera parameter tuple. 
        public void set_cam_par_data(HTuple hv_CameraParamIn, HTuple hv_ParamName, HTuple hv_ParamValue,
            out HTuple hv_CameraParamOut)
        {



            // Local iconic variables 

            // Local control variables 

            HTuple hv_Index = null, hv_ParamNameInd = new HTuple();
            HTuple hv_CameraParamNames = null, hv_I = new HTuple();
            HTuple hv_CameraType = null, hv_IsTelecentric = new HTuple();
            // Initialize local and output iconic variables 
            //set_cam_par_data sets the value of the parameter that
            //is given in ParamName in the tuple of camera parameters
            //given in CameraParamIn. The modified camera parameters
            //are returned in CameraParamOut.
            //
            //Check for consistent length of input parameters
            if ((int)new HTuple(new HTuple(hv_ParamName.TupleLength()).TupleNotEqual(new HTuple(hv_ParamValue.TupleLength()
                ))) != 0)
            {
                throw new HalconException("Different number of values in ParamName and ParamValue");
            }
            //First, get the parameter names that correspond to the
            //elements in the input camera parameter tuple.
            get_cam_par_names(hv_CameraParamIn, out hv_CameraType, out hv_CameraParamNames);
            //
            //Find the index of the requested camera data and return
            //the corresponding value.
            hv_CameraParamOut = hv_CameraParamIn.Clone();
            for (hv_Index = 0; (int)hv_Index <= (int)(new HTuple(hv_ParamName.TupleLength()) - 1); hv_Index = (int)hv_Index + 1)
            {
                Application.DoEvents();
                hv_ParamNameInd = hv_ParamName.TupleSelect(hv_Index);
                hv_I = hv_CameraParamNames.TupleFind(hv_ParamNameInd);
                if ((int)new HTuple(hv_I.TupleNotEqual(-1)) != 0)
                {
                    if (hv_CameraParamOut == null)
                        hv_CameraParamOut = new HTuple();
                    hv_CameraParamOut[hv_I] = hv_ParamValue.TupleSelect(hv_Index);
                }
                else
                {
                    throw new HalconException("Wrong ParamName " + hv_ParamNameInd);
                }
                //Check the consistency of focus and telecentricity
                if ((int)new HTuple(hv_ParamNameInd.TupleEqual("focus")) != 0)
                {
                    hv_IsTelecentric = new HTuple(hv_CameraType.TupleStrstr("telecentric").TupleNotEqual(
                        -1)).TupleAnd(new HTuple(hv_CameraType.TupleStrstr("image_side_telecentric").TupleEqual(
                        -1)));
                    if ((int)hv_IsTelecentric != 0)
                    {
                        throw new HalconException(new HTuple("Focus for telecentric lenses is always 0, and hence, cannot be changed."));
                    }
                    if ((int)new HTuple(hv_IsTelecentric.TupleNot()).TupleAnd(new HTuple(hv_ParamValue.TupleSelect(
                        hv_Index).TupleEqual(0.0))) != 0)
                    {
                        throw new HalconException("Focus for non-telecentric lenses must not be 0.");
                    }
                }
            }

            return;
        }

        // Chapter: Graphics / Output
        // Short Description: Reflect the pose change that was introduced by the user by moving the mouse 
        public void analyze_graph_event(HObject ho_BackgroundImage, HTuple hv_MouseMapping,
            HTuple hv_Button, HTuple hv_Row, HTuple hv_Column, HTuple hv_WindowHandle, HTuple hv_WindowHandleBuffer,
            HTuple hv_VirtualTrackball, HTuple hv_TrackballSize, HTuple hv_SelectedObjectIn,
            HTuple hv_Scene3D, HTuple hv_AlphaOrig, HTuple hv_ObjectModel3DID, HTuple hv_CamParam,
            HTuple hv_Labels, HTuple hv_Title, HTuple hv_Information, HTuple hv_GenParamName,
            HTuple hv_GenParamValue, HTuple hv_PosesIn, HTuple hv_ButtonHoldIn, HTuple hv_TBCenter,
            HTuple hv_TBSize, HTuple hv_WindowCenteredRotationlIn, HTuple hv_MaxNumModels,
            out HTuple hv_PosesOut, out HTuple hv_SelectedObjectOut, out HTuple hv_ButtonHoldOut,
            out HTuple hv_WindowCenteredRotationOut)
        {




            // Local iconic variables 

            HObject ho_ImageDump = null;

            // Local control variables 

            HTuple ExpTmpLocalVar_gIsSinglePose = new HTuple();
            HTuple hv_VisualizeTB = null, hv_InvLog2 = null, hv_Seconds = new HTuple();
            HTuple hv_ModelIndex = new HTuple(), hv_Exception1 = new HTuple();
            HTuple hv_HomMat3DIdentity = new HTuple(), hv_NumModels = new HTuple();
            HTuple hv_Width = new HTuple(), hv_Height = new HTuple();
            HTuple hv_MinImageSize = new HTuple(), hv_TrackballRadiusPixel = new HTuple();
            HTuple hv_TrackballCenterRow = new HTuple(), hv_TrackballCenterCol = new HTuple();
            HTuple hv_NumChannels = new HTuple(), hv_ColorImage = new HTuple();
            HTuple hv_BAnd = new HTuple(), hv_SensFactor = new HTuple();
            HTuple hv_IsButtonTrans = new HTuple(), hv_IsButtonRot = new HTuple();
            HTuple hv_IsButtonDist = new HTuple(), hv_MRow1 = new HTuple();
            HTuple hv_MCol1 = new HTuple(), hv_ButtonLoop = new HTuple();
            HTuple hv_MRow2 = new HTuple(), hv_MCol2 = new HTuple();
            HTuple hv_PX = new HTuple(), hv_PY = new HTuple(), hv_PZ = new HTuple();
            HTuple hv_QX1 = new HTuple(), hv_QY1 = new HTuple(), hv_QZ1 = new HTuple();
            HTuple hv_QX2 = new HTuple(), hv_QY2 = new HTuple(), hv_QZ2 = new HTuple();
            HTuple hv_Len = new HTuple(), hv_Dist = new HTuple(), hv_Translate = new HTuple();
            HTuple hv_Index = new HTuple(), hv_PoseIn = new HTuple();
            HTuple hv_HomMat3DIn = new HTuple(), hv_HomMat3DOut = new HTuple();
            HTuple hv_PoseOut = new HTuple(), hv_Indices = new HTuple();
            HTuple hv_Sequence = new HTuple(), hv_Mod = new HTuple();
            HTuple hv_SequenceReal = new HTuple(), hv_Sequence2Int = new HTuple();
            HTuple hv_Selected = new HTuple(), hv_InvSelected = new HTuple();
            HTuple hv_Exception = new HTuple(), hv_DRow = new HTuple();
            HTuple hv_TranslateZ = new HTuple(), hv_MX1 = new HTuple();
            HTuple hv_MY1 = new HTuple(), hv_MX2 = new HTuple(), hv_MY2 = new HTuple();
            HTuple hv_RelQuaternion = new HTuple(), hv_HomMat3DRotRel = new HTuple();
            HTuple hv_HomMat3DInTmp1 = new HTuple(), hv_HomMat3DInTmp = new HTuple();
            HTuple hv_PosesOut2 = new HTuple();
            HTuple hv_Column_COPY_INP_TMP = hv_Column.Clone();
            HTuple hv_PosesIn_COPY_INP_TMP = hv_PosesIn.Clone();
            HTuple hv_Row_COPY_INP_TMP = hv_Row.Clone();
            HTuple hv_TBCenter_COPY_INP_TMP = hv_TBCenter.Clone();
            HTuple hv_TBSize_COPY_INP_TMP = hv_TBSize.Clone();

            // Initialize local and output iconic variables 
            HOperatorSet.GenEmptyObj(out ho_ImageDump);
            try
            {
                //This procedure reflects
                //- the pose change that was introduced by the user by
                //  moving the mouse
                //- the selection of a single object
                //
                //global tuple gIsSinglePose
                //
                hv_ButtonHoldOut = hv_ButtonHoldIn.Clone();
                hv_PosesOut = hv_PosesIn_COPY_INP_TMP.Clone();
                hv_SelectedObjectOut = hv_SelectedObjectIn.Clone();
                hv_WindowCenteredRotationOut = hv_WindowCenteredRotationlIn.Clone();
                hv_VisualizeTB = new HTuple(hv_SelectedObjectOut.TupleMax().TupleNotEqual(
                    0));
                hv_InvLog2 = 1.0 / new HTuple(2).TupleLog();
                //
                if ((int)new HTuple(hv_Button.TupleEqual(hv_MouseMapping.TupleSelect(6))) != 0)
                {
                    if ((int)hv_ButtonHoldOut != 0)
                    {
                        ho_ImageDump.Dispose();

                        return;
                    }
                    //Ctrl (16) + Alt (32) + left mouse button (1) => Toggle rotation center position
                    //If WindowCenteredRotation is not 1, set it to 1, otherwise, set it to 2
                    HOperatorSet.CountSeconds(out hv_Seconds);
                    if ((int)new HTuple(hv_WindowCenteredRotationOut.TupleEqual(1)) != 0)
                    {
                        hv_WindowCenteredRotationOut = 2;
                    }
                    else
                    {
                        hv_WindowCenteredRotationOut = 1;
                    }
                    hv_ButtonHoldOut = 1;
                    ho_ImageDump.Dispose();

                    return;
                }
                if ((int)new HTuple(hv_Button.TupleEqual(hv_MouseMapping.TupleSelect(5))).TupleAnd(
                    new HTuple(new HTuple(hv_ObjectModel3DID.TupleLength()).TupleLessEqual(
                    hv_MaxNumModels))) != 0)
                {
                    if ((int)hv_ButtonHoldOut != 0)
                    {
                        ho_ImageDump.Dispose();

                        return;
                    }
                    //Ctrl (16) + left mouse button (1) => Select an object
                    try
                    {
                        HOperatorSet.SetScene3dParam(hv_Scene3D, "object_index_persistence", "true");
                        HOperatorSet.DisplayScene3d(hv_ExpDefaultWinHandle, hv_Scene3D, 0);
                        HOperatorSet.GetDisplayScene3dInfo(hv_ExpDefaultWinHandle, hv_Scene3D,
                            hv_Row_COPY_INP_TMP, hv_Column_COPY_INP_TMP, "object_index", out hv_ModelIndex);
                        HOperatorSet.SetScene3dParam(hv_Scene3D, "object_index_persistence", "false");
                    }
                    // catch (Exception1) 
                    catch (HalconException HDevExpDefaultException1)
                    {
                        HDevExpDefaultException1.ToHTuple(out hv_Exception1);
                        //* NO OpenGL, no selection possible
                        ho_ImageDump.Dispose();

                        return;
                    }
                    if ((int)new HTuple(hv_ModelIndex.TupleEqual(-1)) != 0)
                    {
                        //Background click:
                        if ((int)new HTuple(hv_SelectedObjectOut.TupleSum().TupleEqual(new HTuple(hv_SelectedObjectOut.TupleLength()
                            ))) != 0)
                        {
                            //If all objects are already selected, deselect all
                            hv_SelectedObjectOut = HTuple.TupleGenConst(new HTuple(hv_ObjectModel3DID.TupleLength()
                                ), 0);
                        }
                        else
                        {
                            //Otherwise select all
                            hv_SelectedObjectOut = HTuple.TupleGenConst(new HTuple(hv_ObjectModel3DID.TupleLength()
                                ), 1);
                        }
                    }
                    else
                    {
                        //Object click:
                        if (hv_SelectedObjectOut == null)
                            hv_SelectedObjectOut = new HTuple();
                        hv_SelectedObjectOut[hv_ModelIndex] = hv_SelectedObjectOut.TupleSelect(
                            hv_ModelIndex).TupleNot();
                    }
                    hv_ButtonHoldOut = 1;
                }
                else
                {
                    //Change the pose
                    HOperatorSet.HomMat3dIdentity(out hv_HomMat3DIdentity);
                    hv_NumModels = new HTuple(hv_ObjectModel3DID.TupleLength());
                    get_cam_par_data(hv_CamParam, "image_width", out hv_Width);
                    get_cam_par_data(hv_CamParam, "image_height", out hv_Height);
                    hv_MinImageSize = hv_Width.TupleConcat(hv_Height).TupleMin();
                    hv_TrackballRadiusPixel = hv_TrackballSize * hv_MinImageSize / 2.0;
                    //Set trackball fixed in the center of the window
                    hv_TrackballCenterRow = hv_Height / 2;
                    hv_TrackballCenterCol = hv_Width / 2;
                    if ((int)new HTuple(new HTuple(hv_ObjectModel3DID.TupleLength()).TupleLess(
                        hv_MaxNumModels)) != 0)
                    {
                        if ((int)new HTuple(hv_WindowCenteredRotationOut.TupleEqual(1)) != 0)
                        {
                            get_trackball_center_fixed(hv_SelectedObjectIn, hv_TrackballCenterRow,
                                hv_TrackballCenterCol, hv_TrackballRadiusPixel, hv_Scene3D, hv_ObjectModel3DID,
                                hv_PosesIn_COPY_INP_TMP, hv_WindowHandleBuffer, hv_CamParam, hv_GenParamName,
                                hv_GenParamValue, out hv_TBCenter_COPY_INP_TMP, out hv_TBSize_COPY_INP_TMP);
                        }
                        else
                        {
                            get_trackball_center(hv_SelectedObjectIn, hv_TrackballRadiusPixel, hv_ObjectModel3DID,
                                hv_PosesIn_COPY_INP_TMP, out hv_TBCenter_COPY_INP_TMP, out hv_TBSize_COPY_INP_TMP);
                        }
                    }
                    if ((int)new HTuple(hv_SelectedObjectOut.TupleMin().TupleEqual(0)).TupleAnd(
                        new HTuple(hv_SelectedObjectOut.TupleMax().TupleEqual(1))) != 0)
                    {
                        //At this point, multiple objects do not necessary have the same
                        //pose any more. Consequently, we have to return a tuple of poses
                        //as output of visualize_object_model_3d
                        ExpTmpLocalVar_gIsSinglePose = 0;
                        ExpSetGlobalVar_gIsSinglePose(ExpTmpLocalVar_gIsSinglePose);
                    }
                    HOperatorSet.CountChannels(ho_BackgroundImage, out hv_NumChannels);
                    hv_ColorImage = new HTuple(hv_NumChannels.TupleEqual(3));
                    //Alt (32) => lower sensitivity
                    HOperatorSet.TupleRsh(hv_Button, 5, out hv_BAnd);
                    if ((int)(hv_BAnd % 2) != 0)
                    {
                        hv_SensFactor = 0.1;
                    }
                    else
                    {
                        hv_SensFactor = 1.0;
                    }
                    hv_IsButtonTrans = new HTuple(hv_MouseMapping.TupleSelect(0).TupleEqual(
                        hv_Button)).TupleOr(new HTuple((32 + hv_MouseMapping.TupleSelect(0)).TupleEqual(
                        hv_Button)));
                    hv_IsButtonRot = new HTuple(hv_MouseMapping.TupleSelect(1).TupleEqual(
                        hv_Button)).TupleOr(new HTuple((32 + hv_MouseMapping.TupleSelect(1)).TupleEqual(
                        hv_Button)));
                    hv_IsButtonDist = new HTuple(new HTuple(new HTuple(new HTuple(new HTuple(hv_MouseMapping.TupleSelect(
                        2).TupleEqual(hv_Button)).TupleOr(new HTuple((32 + hv_MouseMapping.TupleSelect(
                        2)).TupleEqual(hv_Button)))).TupleOr(new HTuple(hv_MouseMapping.TupleSelect(
                        3).TupleEqual(hv_Button)))).TupleOr(new HTuple((32 + hv_MouseMapping.TupleSelect(
                        3)).TupleEqual(hv_Button)))).TupleOr(new HTuple(hv_MouseMapping.TupleSelect(
                        4).TupleEqual(hv_Button)))).TupleOr(new HTuple((32 + hv_MouseMapping.TupleSelect(
                        4)).TupleEqual(hv_Button)));
                    if ((int)hv_IsButtonTrans != 0)
                    {
                        //Translate in XY-direction
                        hv_MRow1 = hv_Row_COPY_INP_TMP.Clone();
                        hv_MCol1 = hv_Column_COPY_INP_TMP.Clone();
                        while ((int)hv_IsButtonTrans != 0)
                        {
                            Application.DoEvents();
                            try
                            {
                                HOperatorSet.GetMpositionSubPix(hv_ExpDefaultWinHandle, out hv_Row_COPY_INP_TMP,
                                    out hv_Column_COPY_INP_TMP, out hv_ButtonLoop);
                                hv_IsButtonTrans = new HTuple(hv_ButtonLoop.TupleEqual(hv_Button));
                                hv_MRow2 = hv_MRow1 + (hv_Row_COPY_INP_TMP - hv_MRow1) * hv_SensFactor;
                                hv_MCol2 = hv_MCol1 + (hv_Column_COPY_INP_TMP - hv_MCol1) * hv_SensFactor;
                                HOperatorSet.GetLineOfSight(hv_MRow1, hv_MCol1, hv_CamParam, out hv_PX,
                                    out hv_PY, out hv_PZ, out hv_QX1, out hv_QY1, out hv_QZ1);
                                HOperatorSet.GetLineOfSight(hv_MRow2, hv_MCol2, hv_CamParam, out hv_PX,
                                    out hv_PY, out hv_PZ, out hv_QX2, out hv_QY2, out hv_QZ2);
                                hv_Len = (hv_QX1 * hv_QX1 + hv_QY1 * hv_QY1 + hv_QZ1 * hv_QZ1).TupleSqrt()
                                    ;
                                hv_Dist = (hv_TBCenter_COPY_INP_TMP.TupleSelect(0) * hv_TBCenter_COPY_INP_TMP.TupleSelect(
                                    0) + hv_TBCenter_COPY_INP_TMP.TupleSelect(1) * hv_TBCenter_COPY_INP_TMP.TupleSelect(
                                    1) + hv_TBCenter_COPY_INP_TMP.TupleSelect(2) * hv_TBCenter_COPY_INP_TMP.TupleSelect(
                                    2)).TupleSqrt();
                                hv_Translate = (hv_QX2 - hv_QX1).TupleConcat(hv_QY2 - hv_QY1).TupleConcat(
                                    hv_QZ2 - hv_QZ1) * hv_Dist / hv_Len;
                                hv_PosesOut = new HTuple();
                                if ((int)new HTuple(hv_NumModels.TupleLessEqual(hv_MaxNumModels)) != 0)
                                {
                                    HTuple end_val110 = hv_NumModels - 1;
                                    HTuple step_val110 = 1;
                                    for (hv_Index = 0; hv_Index.Continue(end_val110, step_val110); hv_Index = hv_Index.TupleAdd(step_val110))
                                    {
                                        Application.DoEvents();
                                        hv_PoseIn = hv_PosesIn_COPY_INP_TMP.TupleSelectRange(hv_Index * 7,
                                            hv_Index * 7 + 6);
                                        if ((int)hv_SelectedObjectOut.TupleSelect(hv_Index) != 0)
                                        {
                                            HOperatorSet.PoseToHomMat3d(hv_PoseIn, out hv_HomMat3DIn);
                                            HOperatorSet.HomMat3dTranslate(hv_HomMat3DIn, hv_Translate.TupleSelect(
                                                0), hv_Translate.TupleSelect(1), hv_Translate.TupleSelect(
                                                2), out hv_HomMat3DOut);
                                            HOperatorSet.HomMat3dToPose(hv_HomMat3DOut, out hv_PoseOut);
                                            HOperatorSet.SetScene3dInstancePose(hv_Scene3D, hv_Index, hv_PoseOut);
                                        }
                                        else
                                        {
                                            hv_PoseOut = hv_PoseIn.Clone();
                                        }
                                        hv_PosesOut = hv_PosesOut.TupleConcat(hv_PoseOut);
                                    }
                                }
                                else
                                {
                                    HOperatorSet.TupleFind(hv_SelectedObjectOut, 1, out hv_Indices);
                                    hv_PoseIn = hv_PosesIn_COPY_INP_TMP.TupleSelectRange(hv_Indices.TupleSelect(
                                        0) * 7, hv_Indices.TupleSelect(0) * 7 + 6);
                                    HOperatorSet.PoseToHomMat3d(hv_PoseIn, out hv_HomMat3DIn);
                                    HOperatorSet.HomMat3dTranslate(hv_HomMat3DIn, hv_Translate.TupleSelect(
                                        0), hv_Translate.TupleSelect(1), hv_Translate.TupleSelect(2),
                                        out hv_HomMat3DOut);
                                    HOperatorSet.HomMat3dToPose(hv_HomMat3DOut, out hv_PoseOut);
                                    hv_Sequence = HTuple.TupleGenSequence(0, hv_NumModels * 7 - 1, 1);
                                    HOperatorSet.TupleMod(hv_Sequence, 7, out hv_Mod);
                                    hv_SequenceReal = HTuple.TupleGenSequence(0, hv_NumModels - 1.0 / 7.0,
                                        1.0 / 7.0);
                                    hv_Sequence2Int = hv_SequenceReal.TupleInt();
                                    HOperatorSet.TupleSelect(hv_SelectedObjectOut, hv_Sequence2Int, out hv_Selected);
                                    hv_InvSelected = 1 - hv_Selected;
                                    HOperatorSet.TupleSelect(hv_PoseOut, hv_Mod, out hv_PosesOut);
                                    hv_PosesOut = hv_PosesOut * hv_Selected + hv_PosesIn_COPY_INP_TMP * hv_InvSelected;
                                    HOperatorSet.SetScene3dInstancePose(hv_Scene3D, HTuple.TupleGenSequence(
                                        0, hv_NumModels - 1, 1), hv_PosesOut);
                                }
                                dump_image_output(ho_BackgroundImage, hv_ExpDefaultWinHandle, hv_Scene3D,
                                    hv_AlphaOrig, hv_ObjectModel3DID, hv_GenParamName, hv_GenParamValue,
                                    hv_CamParam, hv_PosesOut, hv_ColorImage, hv_Title, hv_Information,
                                    hv_Labels, hv_VisualizeTB, "true", hv_TrackballCenterRow, hv_TrackballCenterCol,
                                    hv_TBSize_COPY_INP_TMP, hv_SelectedObjectOut, new HTuple(hv_WindowCenteredRotationOut.TupleEqual(
                                    1)), hv_TBCenter_COPY_INP_TMP);
                                ho_ImageDump.Dispose();
                                HOperatorSet.DumpWindowImage(out ho_ImageDump, hv_ExpDefaultWinHandle);
                                //dev_set_window(...);
                                HOperatorSet.DispObj(ho_ImageDump, hv_ExpDefaultWinHandle);
                                //
                                hv_MRow1 = hv_Row_COPY_INP_TMP.Clone();
                                hv_MCol1 = hv_Column_COPY_INP_TMP.Clone();
                                hv_PosesIn_COPY_INP_TMP = hv_PosesOut.Clone();
                            }
                            // catch (Exception) 
                            catch (HalconException HDevExpDefaultException1)
                            {
                                HDevExpDefaultException1.ToHTuple(out hv_Exception);
                                //Keep waiting
                            }
                        }
                    }
                    else if ((int)hv_IsButtonDist != 0)
                    {
                        //Change the Z distance
                        hv_MRow1 = hv_Row_COPY_INP_TMP.Clone();
                        while ((int)hv_IsButtonDist != 0)
                        {
                            Application.DoEvents();
                            try
                            {
                                HOperatorSet.GetMpositionSubPix(hv_ExpDefaultWinHandle, out hv_Row_COPY_INP_TMP,
                                    out hv_Column_COPY_INP_TMP, out hv_ButtonLoop);
                                hv_IsButtonDist = new HTuple(hv_ButtonLoop.TupleEqual(hv_Button));
                                hv_MRow2 = hv_Row_COPY_INP_TMP.Clone();
                                hv_DRow = hv_MRow2 - hv_MRow1;
                                hv_Dist = (hv_TBCenter_COPY_INP_TMP.TupleSelect(0) * hv_TBCenter_COPY_INP_TMP.TupleSelect(
                                    0) + hv_TBCenter_COPY_INP_TMP.TupleSelect(1) * hv_TBCenter_COPY_INP_TMP.TupleSelect(
                                    1) + hv_TBCenter_COPY_INP_TMP.TupleSelect(2) * hv_TBCenter_COPY_INP_TMP.TupleSelect(
                                    2)).TupleSqrt();
                                hv_TranslateZ = -hv_Dist * hv_DRow * 0.003 * hv_SensFactor;
                                if (hv_TBCenter_COPY_INP_TMP == null)
                                    hv_TBCenter_COPY_INP_TMP = new HTuple();
                                hv_TBCenter_COPY_INP_TMP[2] = hv_TBCenter_COPY_INP_TMP.TupleSelect(
                                    2) + hv_TranslateZ;
                                hv_PosesOut = new HTuple();
                                if ((int)new HTuple(hv_NumModels.TupleLessEqual(hv_MaxNumModels)) != 0)
                                {
                                    HTuple end_val164 = hv_NumModels - 1;
                                    HTuple step_val164 = 1;
                                    for (hv_Index = 0; hv_Index.Continue(end_val164, step_val164); hv_Index = hv_Index.TupleAdd(step_val164))
                                    {
                                        Application.DoEvents();
                                        hv_PoseIn = hv_PosesIn_COPY_INP_TMP.TupleSelectRange(hv_Index * 7,
                                            hv_Index * 7 + 6);
                                        if ((int)hv_SelectedObjectOut.TupleSelect(hv_Index) != 0)
                                        {
                                            //Transform the whole scene or selected object only
                                            HOperatorSet.PoseToHomMat3d(hv_PoseIn, out hv_HomMat3DIn);
                                            HOperatorSet.HomMat3dTranslate(hv_HomMat3DIn, 0, 0, hv_TranslateZ,
                                                out hv_HomMat3DOut);
                                            HOperatorSet.HomMat3dToPose(hv_HomMat3DOut, out hv_PoseOut);
                                            HOperatorSet.SetScene3dInstancePose(hv_Scene3D, hv_Index, hv_PoseOut);
                                        }
                                        else
                                        {
                                            hv_PoseOut = hv_PoseIn.Clone();
                                        }
                                        hv_PosesOut = hv_PosesOut.TupleConcat(hv_PoseOut);
                                    }
                                }
                                else
                                {
                                    HOperatorSet.TupleFind(hv_SelectedObjectOut, 1, out hv_Indices);
                                    hv_PoseIn = hv_PosesIn_COPY_INP_TMP.TupleSelectRange(hv_Indices.TupleSelect(
                                        0) * 7, hv_Indices.TupleSelect(0) * 7 + 6);
                                    HOperatorSet.PoseToHomMat3d(hv_PoseIn, out hv_HomMat3DIn);
                                    HOperatorSet.HomMat3dTranslate(hv_HomMat3DIn, 0, 0, hv_TranslateZ,
                                        out hv_HomMat3DOut);
                                    HOperatorSet.HomMat3dToPose(hv_HomMat3DOut, out hv_PoseOut);
                                    hv_Sequence = HTuple.TupleGenSequence(0, hv_NumModels * 7 - 1, 1);
                                    HOperatorSet.TupleMod(hv_Sequence, 7, out hv_Mod);
                                    hv_SequenceReal = HTuple.TupleGenSequence(0, hv_NumModels - 1.0 / 7.0,
                                        1.0 / 7.0);
                                    hv_Sequence2Int = hv_SequenceReal.TupleInt();
                                    HOperatorSet.TupleSelect(hv_SelectedObjectOut, hv_Sequence2Int, out hv_Selected);
                                    hv_InvSelected = 1 - hv_Selected;
                                    HOperatorSet.TupleSelect(hv_PoseOut, hv_Mod, out hv_PosesOut);
                                    hv_PosesOut = hv_PosesOut * hv_Selected + hv_PosesIn_COPY_INP_TMP * hv_InvSelected;
                                    HOperatorSet.SetScene3dInstancePose(hv_Scene3D, HTuple.TupleGenSequence(
                                        0, hv_NumModels - 1, 1), hv_PosesOut);
                                }
                                dump_image_output(ho_BackgroundImage, hv_ExpDefaultWinHandle, hv_Scene3D,
                                    hv_AlphaOrig, hv_ObjectModel3DID, hv_GenParamName, hv_GenParamValue,
                                    hv_CamParam, hv_PosesOut, hv_ColorImage, hv_Title, hv_Information,
                                    hv_Labels, hv_VisualizeTB, "true", hv_TrackballCenterRow, hv_TrackballCenterCol,
                                    hv_TBSize_COPY_INP_TMP, hv_SelectedObjectOut, hv_WindowCenteredRotationOut,
                                    hv_TBCenter_COPY_INP_TMP);
                                ho_ImageDump.Dispose();
                                HOperatorSet.DumpWindowImage(out ho_ImageDump, hv_ExpDefaultWinHandle);
                                //dev_set_window(...);
                                HOperatorSet.DispObj(ho_ImageDump, hv_ExpDefaultWinHandle);
                                //
                                hv_MRow1 = hv_Row_COPY_INP_TMP.Clone();
                                hv_PosesIn_COPY_INP_TMP = hv_PosesOut.Clone();
                            }
                            // catch (Exception) 
                            catch (HalconException HDevExpDefaultException1)
                            {
                                HDevExpDefaultException1.ToHTuple(out hv_Exception);
                                //Keep waiting
                            }
                        }
                    }
                    else if ((int)hv_IsButtonRot != 0)
                    {
                        //Rotate the object
                        hv_MRow1 = hv_Row_COPY_INP_TMP.Clone();
                        hv_MCol1 = hv_Column_COPY_INP_TMP.Clone();
                        while ((int)hv_IsButtonRot != 0)
                        {
                            Application.DoEvents();
                            try
                            {
                                HOperatorSet.GetMpositionSubPix(hv_ExpDefaultWinHandle, out hv_Row_COPY_INP_TMP,
                                    out hv_Column_COPY_INP_TMP, out hv_ButtonLoop);
                                hv_IsButtonRot = new HTuple(hv_ButtonLoop.TupleEqual(hv_Button));
                                hv_MRow2 = hv_Row_COPY_INP_TMP.Clone();
                                hv_MCol2 = hv_Column_COPY_INP_TMP.Clone();
                                //Transform the pixel coordinates to relative image coordinates
                                hv_MX1 = (hv_TrackballCenterCol - hv_MCol1) / (0.5 * hv_MinImageSize);
                                hv_MY1 = (hv_TrackballCenterRow - hv_MRow1) / (0.5 * hv_MinImageSize);
                                hv_MX2 = (hv_TrackballCenterCol - hv_MCol2) / (0.5 * hv_MinImageSize);
                                hv_MY2 = (hv_TrackballCenterRow - hv_MRow2) / (0.5 * hv_MinImageSize);
                                //Compute the quaternion rotation that corresponds to the mouse
                                //movement
                                trackball(hv_MX1, hv_MY1, hv_MX2, hv_MY2, hv_VirtualTrackball, hv_TrackballSize,
                                    hv_SensFactor, out hv_RelQuaternion);
                                //Transform the quaternion to a rotation matrix
                                HOperatorSet.QuatToHomMat3d(hv_RelQuaternion, out hv_HomMat3DRotRel);
                                hv_PosesOut = new HTuple();
                                if ((int)new HTuple(hv_NumModels.TupleLessEqual(hv_MaxNumModels)) != 0)
                                {
                                    HTuple end_val226 = hv_NumModels - 1;
                                    HTuple step_val226 = 1;
                                    for (hv_Index = 0; hv_Index.Continue(end_val226, step_val226); hv_Index = hv_Index.TupleAdd(step_val226))
                                    {
                                        Application.DoEvents();
                                        hv_PoseIn = hv_PosesIn_COPY_INP_TMP.TupleSelectRange(hv_Index * 7,
                                            hv_Index * 7 + 6);
                                        if ((int)hv_SelectedObjectOut.TupleSelect(hv_Index) != 0)
                                        {
                                            //Transform the whole scene or selected object only
                                            HOperatorSet.PoseToHomMat3d(hv_PoseIn, out hv_HomMat3DIn);
                                            HOperatorSet.HomMat3dTranslate(hv_HomMat3DIn, -hv_TBCenter_COPY_INP_TMP.TupleSelect(
                                                0), -hv_TBCenter_COPY_INP_TMP.TupleSelect(1), -hv_TBCenter_COPY_INP_TMP.TupleSelect(
                                                2), out hv_HomMat3DIn);
                                            HOperatorSet.HomMat3dCompose(hv_HomMat3DRotRel, hv_HomMat3DIn,
                                                out hv_HomMat3DIn);
                                            HOperatorSet.HomMat3dTranslate(hv_HomMat3DIn, hv_TBCenter_COPY_INP_TMP.TupleSelect(
                                                0), hv_TBCenter_COPY_INP_TMP.TupleSelect(1), hv_TBCenter_COPY_INP_TMP.TupleSelect(
                                                2), out hv_HomMat3DOut);
                                            HOperatorSet.HomMat3dToPose(hv_HomMat3DOut, out hv_PoseOut);
                                            HOperatorSet.SetScene3dInstancePose(hv_Scene3D, hv_Index, hv_PoseOut);
                                        }
                                        else
                                        {
                                            hv_PoseOut = hv_PoseIn.Clone();
                                        }
                                        hv_PosesOut = hv_PosesOut.TupleConcat(hv_PoseOut);
                                    }
                                }
                                else
                                {
                                    HOperatorSet.TupleFind(hv_SelectedObjectOut, 1, out hv_Indices);
                                    hv_PoseIn = hv_PosesIn_COPY_INP_TMP.TupleSelectRange(hv_Indices.TupleSelect(
                                        0) * 7, hv_Indices.TupleSelect(0) * 7 + 6);
                                    HOperatorSet.PoseToHomMat3d(hv_PoseIn, out hv_HomMat3DIn);
                                    HOperatorSet.HomMat3dTranslate(hv_HomMat3DIn, -hv_TBCenter_COPY_INP_TMP.TupleSelect(
                                        0), -hv_TBCenter_COPY_INP_TMP.TupleSelect(1), -hv_TBCenter_COPY_INP_TMP.TupleSelect(
                                        2), out hv_HomMat3DInTmp1);
                                    HOperatorSet.HomMat3dCompose(hv_HomMat3DRotRel, hv_HomMat3DInTmp1,
                                        out hv_HomMat3DInTmp);
                                    HOperatorSet.HomMat3dTranslate(hv_HomMat3DInTmp, hv_TBCenter_COPY_INP_TMP.TupleSelect(
                                        0), hv_TBCenter_COPY_INP_TMP.TupleSelect(1), hv_TBCenter_COPY_INP_TMP.TupleSelect(
                                        2), out hv_HomMat3DOut);
                                    HOperatorSet.HomMat3dToPose(hv_HomMat3DOut, out hv_PoseOut);
                                    hv_Sequence = HTuple.TupleGenSequence(0, hv_NumModels * 7 - 1, 1);
                                    HOperatorSet.TupleMod(hv_Sequence, 7, out hv_Mod);
                                    hv_SequenceReal = HTuple.TupleGenSequence(0, hv_NumModels - 1.0 / 7.0,
                                        1.0 / 7.0);
                                    hv_Sequence2Int = hv_SequenceReal.TupleInt();
                                    HOperatorSet.TupleSelect(hv_SelectedObjectOut, hv_Sequence2Int, out hv_Selected);
                                    hv_InvSelected = 1 - hv_Selected;
                                    HOperatorSet.TupleSelect(hv_PoseOut, hv_Mod, out hv_PosesOut);
                                    hv_PosesOut2 = hv_PosesOut * hv_Selected + hv_PosesIn_COPY_INP_TMP * hv_InvSelected;
                                    hv_PosesOut = hv_PosesOut2.Clone();
                                    HOperatorSet.SetScene3dInstancePose(hv_Scene3D, HTuple.TupleGenSequence(
                                        0, hv_NumModels - 1, 1), hv_PosesOut);
                                }
                                dump_image_output(ho_BackgroundImage, hv_ExpDefaultWinHandle, hv_Scene3D,
                                    hv_AlphaOrig, hv_ObjectModel3DID, hv_GenParamName, hv_GenParamValue,
                                    hv_CamParam, hv_PosesOut, hv_ColorImage, hv_Title, hv_Information,
                                    hv_Labels, hv_VisualizeTB, "true", hv_TrackballCenterRow, hv_TrackballCenterCol,
                                    hv_TBSize_COPY_INP_TMP, hv_SelectedObjectOut, hv_WindowCenteredRotationOut,
                                    hv_TBCenter_COPY_INP_TMP);
                                ho_ImageDump.Dispose();
                                HOperatorSet.DumpWindowImage(out ho_ImageDump, hv_ExpDefaultWinHandle);
                                //dev_set_window(...);
                                HOperatorSet.DispObj(ho_ImageDump, hv_ExpDefaultWinHandle);
                                //
                                hv_MRow1 = hv_Row_COPY_INP_TMP.Clone();
                                hv_MCol1 = hv_Column_COPY_INP_TMP.Clone();
                                hv_PosesIn_COPY_INP_TMP = hv_PosesOut.Clone();
                            }
                            // catch (Exception) 
                            catch (HalconException HDevExpDefaultException1)
                            {
                                HDevExpDefaultException1.ToHTuple(out hv_Exception);
                                //Keep waiting
                            }
                        }
                    }
                    hv_PosesOut = hv_PosesIn_COPY_INP_TMP.Clone();
                }
                ho_ImageDump.Dispose();

                return;
            }
            catch (HalconException HDevExpDefaultException)
            {
                ho_ImageDump.Dispose();

                throw HDevExpDefaultException;
            }
        }

        // Chapter: Graphics / Parameters
        public void color_string_to_rgb(HTuple hv_Color, out HTuple hv_RGB)
        {



            // Local iconic variables 

            HObject ho_Rectangle, ho_Image;

            // Local control variables 

            HTuple hv_WindowHandleBuffer = new HTuple();
            HTuple hv_Exception = null;
            // Initialize local and output iconic variables 
            HOperatorSet.GenEmptyObj(out ho_Rectangle);
            HOperatorSet.GenEmptyObj(out ho_Image);
            try
            {
                //open_window(...);
                HOperatorSet.SetPart(hv_ExpDefaultWinHandle, 0, 0, -1, -1);
                ho_Rectangle.Dispose();
                HOperatorSet.GenRectangle1(out ho_Rectangle, 0, 0, 0, 0);
                try
                {
                    HOperatorSet.SetColor(hv_ExpDefaultWinHandle, hv_Color);
                }
                // catch (Exception) 
                catch (HalconException HDevExpDefaultException1)
                {
                    HDevExpDefaultException1.ToHTuple(out hv_Exception);
                    hv_Exception = "Wrong value of control parameter Color (must be a valid color string)";
                    throw new HalconException(hv_Exception);
                }
                HOperatorSet.DispObj(ho_Rectangle, hv_ExpDefaultWinHandle);
                ho_Image.Dispose();
                HOperatorSet.DumpWindowImage(out ho_Image, hv_ExpDefaultWinHandle);
                //close_window(...);
                HOperatorSet.GetGrayval(ho_Image, 0, 0, out hv_RGB);
                hv_RGB = hv_RGB + new HTuple(0).TupleConcat(0).TupleConcat(0);
                ho_Rectangle.Dispose();
                ho_Image.Dispose();

                return;
            }
            catch (HalconException HDevExpDefaultException)
            {
                ho_Rectangle.Dispose();
                ho_Image.Dispose();

                throw HDevExpDefaultException;
            }
        }

        // Chapter: Graphics / Output
        // Short Description: Determine the optimum distance of the object to obtain a reasonable visualization 
        public void determine_optimum_pose_distance(HTuple hv_ObjectModel3DID, HTuple hv_CamParam,
            HTuple hv_ImageCoverage, HTuple hv_PoseIn, out HTuple hv_PoseOut)
        {



            // Local iconic variables 

            // Local control variables 

            HTuple hv_NumModels = null, hv_Rows = null;
            HTuple hv_Cols = null, hv_MinMinZ = null, hv_BB = null;
            HTuple hv_Seq = null, hv_DXMax = null, hv_DYMax = null;
            HTuple hv_DZMax = null, hv_Diameter = null, hv_ZAdd = null;
            HTuple hv_IBB = null, hv_BB0 = null, hv_BB1 = null, hv_BB2 = null;
            HTuple hv_BB3 = null, hv_BB4 = null, hv_BB5 = null, hv_X = null;
            HTuple hv_Y = null, hv_Z = null, hv_PoseInter = null, hv_HomMat3D = null;
            HTuple hv_QX = null, hv_QY = null, hv_QZ = null, hv_Cx = null;
            HTuple hv_Cy = null, hv_DR = null, hv_DC = null, hv_MaxDist = null;
            HTuple hv_HomMat3DRotate = new HTuple(), hv_ImageWidth = null;
            HTuple hv_ImageHeight = null, hv_MinImageSize = null, hv_Zs = null;
            HTuple hv_ZDiff = null, hv_ScaleZ = null, hv_ZNew = null;
            // Initialize local and output iconic variables 
            //Determine the optimum distance of the object to obtain
            //a reasonable visualization
            //
            hv_NumModels = new HTuple(hv_ObjectModel3DID.TupleLength());
            hv_Rows = new HTuple();
            hv_Cols = new HTuple();
            hv_MinMinZ = 1e30;
            HOperatorSet.GetObjectModel3dParams(hv_ObjectModel3DID, "bounding_box1", out hv_BB);
            //Calculate diameter over all objects to be visualized
            hv_Seq = HTuple.TupleGenSequence(0, new HTuple(hv_BB.TupleLength()) - 1, 6);
            hv_DXMax = hv_BB.TupleSelect(hv_Seq + 3).TupleMax() - hv_BB.TupleSelect(
                hv_Seq).TupleMin();
            hv_DYMax = hv_BB.TupleSelect(hv_Seq + 4).TupleMax() - hv_BB.TupleSelect(
                hv_Seq + 1).TupleMin();
            hv_DZMax = hv_BB.TupleSelect(hv_Seq + 5).TupleMax() - hv_BB.TupleSelect(
                hv_Seq + 2).TupleMin();
            hv_Diameter = (hv_DXMax * hv_DXMax + hv_DYMax * hv_DYMax + hv_DZMax * hv_DZMax).TupleSqrt()
                ;
            if ((int)new HTuple(hv_BB.TupleAbs().TupleSum().TupleEqual(0.0)) != 0)
            {
                hv_BB = new HTuple();
                hv_BB = hv_BB.TupleConcat(-new HTuple(HTuple.TupleRand(
                    3) * 1e-20).TupleAbs());
                hv_BB = hv_BB.TupleConcat(new HTuple(HTuple.TupleRand(
                    3) * 1e-20).TupleAbs());
            }
            //Allow the visualization of single points or extremely small objects
            hv_ZAdd = 0.0;
            if ((int)new HTuple(hv_Diameter.TupleMax().TupleLess(1e-10)) != 0)
            {
                hv_ZAdd = 0.01;
            }
            //Set extremely small diameters to 1e-10 to avoid CZ == 0.0, which would lead
            //to projection errors
            if ((int)new HTuple(hv_Diameter.TupleMin().TupleLess(1e-10)) != 0)
            {
                hv_Diameter = hv_Diameter - ((hv_Diameter - 1e-10).TupleSgn() - 1).TupleSgn()
                     * 1e-10;
            }
            hv_IBB = HTuple.TupleGenSequence(0, new HTuple(hv_BB.TupleLength()) - 1, 6);
            hv_BB0 = hv_BB.TupleSelect(hv_IBB);
            hv_BB1 = hv_BB.TupleSelect(hv_IBB + 1);
            hv_BB2 = hv_BB.TupleSelect(hv_IBB + 2);
            hv_BB3 = hv_BB.TupleSelect(hv_IBB + 3);
            hv_BB4 = hv_BB.TupleSelect(hv_IBB + 4);
            hv_BB5 = hv_BB.TupleSelect(hv_IBB + 5);
            hv_X = new HTuple();
            hv_X = hv_X.TupleConcat(hv_BB0);
            hv_X = hv_X.TupleConcat(hv_BB3);
            hv_X = hv_X.TupleConcat(hv_BB0);
            hv_X = hv_X.TupleConcat(hv_BB0);
            hv_X = hv_X.TupleConcat(hv_BB3);
            hv_X = hv_X.TupleConcat(hv_BB3);
            hv_X = hv_X.TupleConcat(hv_BB0);
            hv_X = hv_X.TupleConcat(hv_BB3);
            hv_Y = new HTuple();
            hv_Y = hv_Y.TupleConcat(hv_BB1);
            hv_Y = hv_Y.TupleConcat(hv_BB1);
            hv_Y = hv_Y.TupleConcat(hv_BB4);
            hv_Y = hv_Y.TupleConcat(hv_BB1);
            hv_Y = hv_Y.TupleConcat(hv_BB4);
            hv_Y = hv_Y.TupleConcat(hv_BB1);
            hv_Y = hv_Y.TupleConcat(hv_BB4);
            hv_Y = hv_Y.TupleConcat(hv_BB4);
            hv_Z = new HTuple();
            hv_Z = hv_Z.TupleConcat(hv_BB2);
            hv_Z = hv_Z.TupleConcat(hv_BB2);
            hv_Z = hv_Z.TupleConcat(hv_BB2);
            hv_Z = hv_Z.TupleConcat(hv_BB5);
            hv_Z = hv_Z.TupleConcat(hv_BB2);
            hv_Z = hv_Z.TupleConcat(hv_BB5);
            hv_Z = hv_Z.TupleConcat(hv_BB5);
            hv_Z = hv_Z.TupleConcat(hv_BB5);
            hv_PoseInter = hv_PoseIn.TupleReplace(2, -hv_Z.TupleMin() + 2 * hv_Diameter.TupleMax()
                );
            HOperatorSet.PoseToHomMat3d(hv_PoseInter, out hv_HomMat3D);
            //Determine the maximum extension of the projection
            HOperatorSet.AffineTransPoint3d(hv_HomMat3D, hv_X, hv_Y, hv_Z, out hv_QX, out hv_QY,
                out hv_QZ);
            HOperatorSet.Project3dPoint(hv_QX, hv_QY, hv_QZ, hv_CamParam, out hv_Rows, out hv_Cols);
            hv_MinMinZ = hv_QZ.TupleMin();
            get_cam_par_data(hv_CamParam, "cx", out hv_Cx);
            get_cam_par_data(hv_CamParam, "cy", out hv_Cy);
            hv_DR = hv_Rows - hv_Cy;
            hv_DC = hv_Cols - hv_Cx;
            hv_DR = hv_DR.TupleMax() - hv_DR.TupleMin();
            hv_DC = hv_DC.TupleMax() - hv_DC.TupleMin();
            hv_MaxDist = (hv_DR * hv_DR + hv_DC * hv_DC).TupleSqrt();
            //
            if ((int)new HTuple(hv_MaxDist.TupleLess(1e-10)) != 0)
            {
                //If the object has no extension in the above projection (looking along
                //a line), we determine the extension of the object in a rotated view
                HOperatorSet.HomMat3dRotateLocal(hv_HomMat3D, new HTuple(90).TupleRad(),
                    "x", out hv_HomMat3DRotate);
                HOperatorSet.AffineTransPoint3d(hv_HomMat3DRotate, hv_X, hv_Y, hv_Z, out hv_QX,
                    out hv_QY, out hv_QZ);
                HOperatorSet.Project3dPoint(hv_QX, hv_QY, hv_QZ, hv_CamParam, out hv_Rows,
                    out hv_Cols);
                hv_DR = hv_Rows - hv_Cy;
                hv_DC = hv_Cols - hv_Cx;
                hv_DR = hv_DR.TupleMax() - hv_DR.TupleMin();
                hv_DC = hv_DC.TupleMax() - hv_DC.TupleMin();
                hv_MaxDist = hv_MaxDist.TupleConcat((hv_DR * hv_DR + hv_DC * hv_DC).TupleSqrt()
                    ).TupleMax();
            }
            //
            get_cam_par_data(hv_CamParam, "image_width", out hv_ImageWidth);
            get_cam_par_data(hv_CamParam, "image_height", out hv_ImageHeight);
            hv_MinImageSize = hv_ImageWidth.TupleConcat(hv_ImageHeight).TupleMin();
            //
            hv_Z = hv_PoseInter.TupleSelect(2);
            hv_Zs = hv_MinMinZ.Clone();
            hv_ZDiff = hv_Z - hv_Zs;
            hv_ScaleZ = hv_MaxDist / (0.5 * hv_MinImageSize * hv_ImageCoverage * 2.0);
            hv_ZNew = hv_ScaleZ * hv_Zs + hv_ZDiff + hv_ZAdd;
            hv_PoseOut = hv_PoseInter.TupleReplace(2, hv_ZNew);
            //

            return;
        }

        // Chapter: Graphics / Output
        // Short Description: Displays a continue button. 


        // Chapter: Graphics / Output
        // Short Description: Can replace disp_object_model_3d if there is no OpenGL available. 
        public void disp_object_model_no_opengl(out HObject ho_ModelContours, HTuple hv_ObjectModel3DID,
            HTuple hv_GenParamName, HTuple hv_GenParamValue, HTuple hv_WindowHandleBuffer,
            HTuple hv_CamParam, HTuple hv_PosesOut)
        {



            // Local iconic variables 

            // Local control variables 

            HTuple hv_Idx = null, hv_CustomParamName = new HTuple();
            HTuple hv_CustomParamValue = new HTuple(), hv_Font = null;
            HTuple hv_IndicesDispBackGround = null, hv_Indices = new HTuple();
            HTuple hv_ImageWidth = null, hv_HasPolygons = null, hv_HasTri = null;
            HTuple hv_HasPoints = null, hv_HasLines = null, hv_NumPoints = null;
            HTuple hv_IsPrimitive = null, hv_Center = null, hv_Diameter = null;
            HTuple hv_OpenGlHiddenSurface = null, hv_CenterX = null;
            HTuple hv_CenterY = null, hv_CenterZ = null, hv_PosObjectsZ = null;
            HTuple hv_I = new HTuple(), hv_Pose = new HTuple(), hv_HomMat3DObj = new HTuple();
            HTuple hv_PosObjCenterX = new HTuple(), hv_PosObjCenterY = new HTuple();
            HTuple hv_PosObjCenterZ = new HTuple(), hv_PosObjectsX = new HTuple();
            HTuple hv_PosObjectsY = new HTuple(), hv_Color = null;
            HTuple hv_Indices1 = new HTuple(), hv_Indices2 = new HTuple();
            HTuple hv_J = null, hv_Indices3 = new HTuple(), hv_HomMat3D = new HTuple();
            HTuple hv_SampledObjectModel3D = new HTuple(), hv_X = new HTuple();
            HTuple hv_Y = new HTuple(), hv_Z = new HTuple(), hv_HomMat3D1 = new HTuple();
            HTuple hv_Qx = new HTuple(), hv_Qy = new HTuple(), hv_Qz = new HTuple();
            HTuple hv_Row = new HTuple(), hv_Column = new HTuple();
            HTuple hv_ObjectModel3DConvexHull = new HTuple(), hv_Exception = new HTuple();
            // Initialize local and output iconic variables 
            HOperatorSet.GenEmptyObj(out ho_ModelContours);
            //This procedure allows to use project_object_model_3d to simulate a disp_object_model_3d
            //call for small objects. Large objects are sampled down to display.
            hv_Idx = hv_GenParamName.TupleFind("point_size");
            if ((int)new HTuple(hv_Idx.TupleLength()).TupleAnd(new HTuple(hv_Idx.TupleNotEqual(
                -1))) != 0)
            {
                hv_CustomParamName = "point_size";
                hv_CustomParamValue = hv_GenParamValue.TupleSelect(hv_Idx);
                if ((int)new HTuple(hv_CustomParamValue.TupleEqual(1)) != 0)
                {
                    hv_CustomParamValue = 0;
                }
            }
            else
            {
                hv_CustomParamName = new HTuple();
                hv_CustomParamValue = new HTuple();
            }
            HOperatorSet.GetFont(hv_ExpDefaultWinHandle, out hv_Font);
            HOperatorSet.TupleFind(hv_GenParamName, "disp_background", out hv_IndicesDispBackGround);
            if ((int)new HTuple(hv_IndicesDispBackGround.TupleNotEqual(-1)) != 0)
            {
                HOperatorSet.TupleFind(hv_GenParamName.TupleSelect(hv_IndicesDispBackGround),
                    "false", out hv_Indices);
                if ((int)new HTuple(hv_Indices.TupleNotEqual(-1)) != 0)
                {
                    HOperatorSet.ClearWindow(hv_ExpDefaultWinHandle);
                }
            }
            set_display_font(hv_ExpDefaultWinHandle, 11, "mono", "false", "false");
            get_cam_par_data(hv_CamParam, "image_width", out hv_ImageWidth);
            disp_message(hv_ExpDefaultWinHandle, "OpenGL missing!", "image", 5, hv_ImageWidth - 130,
                "red", "false");
            HOperatorSet.SetFont(hv_ExpDefaultWinHandle, hv_Font);
            HOperatorSet.GetObjectModel3dParams(hv_ObjectModel3DID, "has_polygons", out hv_HasPolygons);
            HOperatorSet.GetObjectModel3dParams(hv_ObjectModel3DID, "has_triangles", out hv_HasTri);
            HOperatorSet.GetObjectModel3dParams(hv_ObjectModel3DID, "has_points", out hv_HasPoints);
            HOperatorSet.GetObjectModel3dParams(hv_ObjectModel3DID, "has_lines", out hv_HasLines);
            HOperatorSet.GetObjectModel3dParams(hv_ObjectModel3DID, "num_points", out hv_NumPoints);
            HOperatorSet.GetObjectModel3dParams(hv_ObjectModel3DID, "has_primitive_data",
                out hv_IsPrimitive);
            HOperatorSet.GetObjectModel3dParams(hv_ObjectModel3DID, "center", out hv_Center);
            HOperatorSet.GetObjectModel3dParams(hv_ObjectModel3DID, "diameter", out hv_Diameter);
            HOperatorSet.GetSystem("opengl_hidden_surface_removal_enable", out hv_OpenGlHiddenSurface);
            HOperatorSet.SetSystem("opengl_hidden_surface_removal_enable", "false");
            //Sort the objects by inverse z
            hv_CenterX = hv_Center.TupleSelect(HTuple.TupleGenSequence(0, new HTuple(hv_Center.TupleLength()
                ) - 1, 3));
            hv_CenterY = hv_Center.TupleSelect(HTuple.TupleGenSequence(0, new HTuple(hv_Center.TupleLength()
                ) - 1, 3) + 1);
            hv_CenterZ = hv_Center.TupleSelect(HTuple.TupleGenSequence(0, new HTuple(hv_Center.TupleLength()
                ) - 1, 3) + 2);
            hv_PosObjectsZ = new HTuple();
            if ((int)new HTuple(new HTuple(hv_PosesOut.TupleLength()).TupleGreater(7)) != 0)
            {
                for (hv_I = 0; (int)hv_I <= (int)(new HTuple(hv_ObjectModel3DID.TupleLength()) - 1); hv_I = (int)hv_I + 1)
                {
                    Application.DoEvents();
                    hv_Pose = hv_PosesOut.TupleSelectRange(hv_I * 7, hv_I * 7 + 6);
                    HOperatorSet.PoseToHomMat3d(hv_Pose, out hv_HomMat3DObj);
                    HOperatorSet.AffineTransPoint3d(hv_HomMat3DObj, hv_CenterX.TupleSelect(hv_I),
                        hv_CenterY.TupleSelect(hv_I), hv_CenterZ.TupleSelect(hv_I), out hv_PosObjCenterX,
                        out hv_PosObjCenterY, out hv_PosObjCenterZ);
                    hv_PosObjectsZ = hv_PosObjectsZ.TupleConcat(hv_PosObjCenterZ);
                }
            }
            else
            {
                hv_Pose = hv_PosesOut.TupleSelectRange(0, 6);
                HOperatorSet.PoseToHomMat3d(hv_Pose, out hv_HomMat3DObj);
                HOperatorSet.AffineTransPoint3d(hv_HomMat3DObj, hv_CenterX, hv_CenterY, hv_CenterZ,
                    out hv_PosObjectsX, out hv_PosObjectsY, out hv_PosObjectsZ);
            }
            hv_Idx = hv_PosObjectsZ.TupleSortIndex().TupleInverse();
            hv_Color = "white";
            HOperatorSet.SetColor(hv_ExpDefaultWinHandle, hv_Color);
            if ((int)new HTuple(new HTuple(hv_GenParamName.TupleLength()).TupleGreater(
                0)) != 0)
            {
                HOperatorSet.TupleFind(hv_GenParamName, "colored", out hv_Indices1);
                HOperatorSet.TupleFind(hv_GenParamName, "color", out hv_Indices2);
                if ((int)new HTuple(hv_Indices1.TupleSelect(0).TupleNotEqual(-1)) != 0)
                {
                    if ((int)new HTuple(hv_GenParamValue.TupleSelect(hv_Indices1.TupleSelect(
                        0)).TupleEqual(3)) != 0)
                    {
                        hv_Color = new HTuple();
                        hv_Color[0] = "red";
                        hv_Color[1] = "green";
                        hv_Color[2] = "blue";
                    }
                    else if ((int)new HTuple(hv_GenParamValue.TupleSelect(hv_Indices1.TupleSelect(
                        0)).TupleEqual(6)) != 0)
                    {
                        hv_Color = new HTuple();
                        hv_Color[0] = "red";
                        hv_Color[1] = "green";
                        hv_Color[2] = "blue";
                        hv_Color[3] = "cyan";
                        hv_Color[4] = "magenta";
                        hv_Color[5] = "yellow";
                    }
                    else if ((int)new HTuple(hv_GenParamValue.TupleSelect(hv_Indices1.TupleSelect(
                        0)).TupleEqual(12)) != 0)
                    {
                        hv_Color = new HTuple();
                        hv_Color[0] = "red";
                        hv_Color[1] = "green";
                        hv_Color[2] = "blue";
                        hv_Color[3] = "cyan";
                        hv_Color[4] = "magenta";
                        hv_Color[5] = "yellow";
                        hv_Color[6] = "coral";
                        hv_Color[7] = "slate blue";
                        hv_Color[8] = "spring green";
                        hv_Color[9] = "orange red";
                        hv_Color[10] = "pink";
                        hv_Color[11] = "gold";
                    }
                }
                else if ((int)new HTuple(hv_Indices2.TupleSelect(0).TupleNotEqual(
                    -1)) != 0)
                {
                    hv_Color = hv_GenParamValue.TupleSelect(hv_Indices2.TupleSelect(0));
                }
            }
            for (hv_J = 0; (int)hv_J <= (int)(new HTuple(hv_ObjectModel3DID.TupleLength()) - 1); hv_J = (int)hv_J + 1)
            {
                Application.DoEvents();
                hv_I = hv_Idx.TupleSelect(hv_J);
                if ((int)new HTuple(new HTuple(new HTuple(hv_HasPolygons.TupleSelect(
                    hv_I).TupleEqual("true")).TupleOr(new HTuple(hv_HasTri.TupleSelect(
                    hv_I).TupleEqual("true")))).TupleOr(new HTuple(hv_HasPoints.TupleSelect(
                    hv_I).TupleEqual("true")))).TupleOr(new HTuple(hv_HasLines.TupleSelect(
                    hv_I).TupleEqual("true"))) != 0)
                {
                    if ((int)new HTuple(new HTuple(hv_GenParamName.TupleLength()).TupleGreater(
                        0)) != 0)
                    {
                        HOperatorSet.TupleFind(hv_GenParamName, "color_" + hv_I, out hv_Indices3);
                        if ((int)new HTuple(hv_Indices3.TupleSelect(0).TupleNotEqual(-1)) != 0)
                        {
                            HOperatorSet.SetColor(hv_ExpDefaultWinHandle, hv_GenParamValue.TupleSelect(
                                hv_Indices3.TupleSelect(0)));
                        }
                        else
                        {
                            HOperatorSet.SetColor(hv_ExpDefaultWinHandle, hv_Color.TupleSelect(hv_I % new HTuple(hv_Color.TupleLength()
                                )));
                        }
                    }
                    if ((int)new HTuple(new HTuple(hv_PosesOut.TupleLength()).TupleGreaterEqual(
                        hv_I * 7 + 6)) != 0)
                    {
                        hv_Pose = hv_PosesOut.TupleSelectRange(hv_I * 7, hv_I * 7 + 6);
                    }
                    else
                    {
                        hv_Pose = hv_PosesOut.TupleSelectRange(0, 6);
                    }
                    if ((int)new HTuple(hv_NumPoints.TupleSelect(hv_I).TupleLess(10000)) != 0)
                    {
                        ho_ModelContours.Dispose();
                        HOperatorSet.ProjectObjectModel3d(out ho_ModelContours, hv_ObjectModel3DID.TupleSelect(
                            hv_I), hv_CamParam, hv_Pose, hv_CustomParamName, hv_CustomParamValue);
                        HOperatorSet.DispObj(ho_ModelContours, hv_ExpDefaultWinHandle);
                    }
                    else
                    {
                        HOperatorSet.PoseToHomMat3d(hv_Pose, out hv_HomMat3D);
                        HOperatorSet.SampleObjectModel3d(hv_ObjectModel3DID.TupleSelect(hv_I),
                            "fast", 0.01 * hv_Diameter.TupleSelect(hv_I), new HTuple(), new HTuple(),
                            out hv_SampledObjectModel3D);
                        ho_ModelContours.Dispose();
                        HOperatorSet.ProjectObjectModel3d(out ho_ModelContours, hv_SampledObjectModel3D,
                            hv_CamParam, hv_Pose, "point_size", 1);
                        HOperatorSet.GetObjectModel3dParams(hv_SampledObjectModel3D, "point_coord_x",
                            out hv_X);
                        HOperatorSet.GetObjectModel3dParams(hv_SampledObjectModel3D, "point_coord_y",
                            out hv_Y);
                        HOperatorSet.GetObjectModel3dParams(hv_SampledObjectModel3D, "point_coord_z",
                            out hv_Z);
                        HOperatorSet.PoseToHomMat3d(hv_Pose, out hv_HomMat3D1);
                        HOperatorSet.AffineTransPoint3d(hv_HomMat3D1, hv_X, hv_Y, hv_Z, out hv_Qx,
                            out hv_Qy, out hv_Qz);
                        HOperatorSet.Project3dPoint(hv_Qx, hv_Qy, hv_Qz, hv_CamParam, out hv_Row,
                            out hv_Column);
                        HOperatorSet.DispObj(ho_ModelContours, hv_ExpDefaultWinHandle);
                        HOperatorSet.ClearObjectModel3d(hv_SampledObjectModel3D);
                    }
                }
                else
                {
                    if ((int)new HTuple(new HTuple(hv_GenParamName.TupleLength()).TupleGreater(
                        0)) != 0)
                    {
                        HOperatorSet.TupleFind(hv_GenParamName, "color_" + hv_I, out hv_Indices3);
                        if ((int)new HTuple(hv_Indices3.TupleSelect(0).TupleNotEqual(-1)) != 0)
                        {
                            HOperatorSet.SetColor(hv_ExpDefaultWinHandle, hv_GenParamValue.TupleSelect(
                                hv_Indices3.TupleSelect(0)));
                        }
                        else
                        {
                            HOperatorSet.SetColor(hv_ExpDefaultWinHandle, hv_Color.TupleSelect(hv_I % new HTuple(hv_Color.TupleLength()
                                )));
                        }
                    }
                    if ((int)new HTuple(new HTuple(hv_PosesOut.TupleLength()).TupleGreaterEqual(
                        hv_I * 7 + 6)) != 0)
                    {
                        hv_Pose = hv_PosesOut.TupleSelectRange(hv_I * 7, hv_I * 7 + 6);
                    }
                    else
                    {
                        hv_Pose = hv_PosesOut.TupleSelectRange(0, 6);
                    }
                    if ((int)new HTuple(hv_IsPrimitive.TupleSelect(hv_I).TupleEqual("true")) != 0)
                    {
                        try
                        {
                            HOperatorSet.ConvexHullObjectModel3d(hv_ObjectModel3DID.TupleSelect(hv_I),
                                out hv_ObjectModel3DConvexHull);
                            if ((int)new HTuple(hv_NumPoints.TupleSelect(hv_I).TupleLess(10000)) != 0)
                            {
                                ho_ModelContours.Dispose();
                                HOperatorSet.ProjectObjectModel3d(out ho_ModelContours, hv_ObjectModel3DConvexHull,
                                    hv_CamParam, hv_Pose, hv_CustomParamName, hv_CustomParamValue);
                                HOperatorSet.DispObj(ho_ModelContours, hv_ExpDefaultWinHandle);
                            }
                            else
                            {
                                HOperatorSet.PoseToHomMat3d(hv_Pose, out hv_HomMat3D);
                                HOperatorSet.SampleObjectModel3d(hv_ObjectModel3DConvexHull, "fast",
                                    0.01 * hv_Diameter.TupleSelect(hv_I), new HTuple(), new HTuple(),
                                    out hv_SampledObjectModel3D);
                                ho_ModelContours.Dispose();
                                HOperatorSet.ProjectObjectModel3d(out ho_ModelContours, hv_SampledObjectModel3D,
                                    hv_CamParam, hv_Pose, "point_size", 1);
                                HOperatorSet.DispObj(ho_ModelContours, hv_ExpDefaultWinHandle);
                                HOperatorSet.ClearObjectModel3d(hv_SampledObjectModel3D);
                            }
                            HOperatorSet.ClearObjectModel3d(hv_ObjectModel3DConvexHull);
                        }
                        // catch (Exception) 
                        catch (HalconException HDevExpDefaultException1)
                        {
                            HDevExpDefaultException1.ToHTuple(out hv_Exception);
                        }
                    }
                }
            }
            HOperatorSet.SetSystem("opengl_hidden_surface_removal_enable", hv_OpenGlHiddenSurface);

            return;
        }

        // Chapter: Graphics / Output
        public void disp_title_and_information(HTuple hv_WindowHandle, HTuple hv_Title,
            HTuple hv_Information)
        {



            // Local iconic variables 

            // Local control variables 

            HTuple hv_WinRow = null, hv_WinColumn = null;
            HTuple hv_WinWidth = new HTuple(), hv_WinHeight = null;
            HTuple hv_NumTitleLines = null, hv_Row = new HTuple();
            HTuple hv_Column = new HTuple(), hv_TextWidth = new HTuple();
            HTuple hv_NumInfoLines = null, hv_Ascent = new HTuple();
            HTuple hv_Descent = new HTuple(), hv_Width = new HTuple();
            HTuple hv_Height = new HTuple();
            HTuple hv_Information_COPY_INP_TMP = hv_Information.Clone();
            HTuple hv_Title_COPY_INP_TMP = hv_Title.Clone();

            // Initialize local and output iconic variables 
            //global tuple gInfoDecor
            //global tuple gInfoPos
            //global tuple gTitlePos
            //global tuple gTitleDecor
            //
            HOperatorSet.GetWindowExtents(hv_ExpDefaultWinHandle, out hv_WinRow, out hv_WinColumn,
                out hv_WinWidth, out hv_WinHeight);
            hv_Title_COPY_INP_TMP = ("" + hv_Title_COPY_INP_TMP + "").TupleSplit("\n");
            hv_NumTitleLines = new HTuple(hv_Title_COPY_INP_TMP.TupleLength());
            if ((int)new HTuple(hv_NumTitleLines.TupleGreater(0)) != 0)
            {
                hv_Row = 12;
                if ((int)new HTuple(ExpGetGlobalVar_gTitlePos().TupleEqual("UpperLeft")) != 0)
                {
                    hv_Column = 12;
                }
                else if ((int)new HTuple(ExpGetGlobalVar_gTitlePos().TupleEqual("UpperCenter")) != 0)
                {
                    max_line_width(hv_WindowHandle, hv_Title_COPY_INP_TMP, out hv_TextWidth);
                    hv_Column = hv_WinWidth / 2 - hv_TextWidth / 2;
                }
                else if ((int)new HTuple(ExpGetGlobalVar_gTitlePos().TupleEqual("UpperRight")) != 0)
                {
                    if ((int)new HTuple(ExpGetGlobalVar_gTitleDecor().TupleSelect(1).TupleEqual(
                        "true")) != 0)
                    {
                        max_line_width(hv_WindowHandle, hv_Title_COPY_INP_TMP + "  ", out hv_TextWidth);
                    }
                    else
                    {
                        max_line_width(hv_WindowHandle, hv_Title_COPY_INP_TMP, out hv_TextWidth);
                    }
                    hv_Column = hv_WinWidth - hv_TextWidth - 10;
                }
                else
                {

                }
                disp_message(hv_ExpDefaultWinHandle, hv_Title_COPY_INP_TMP, "window", hv_Row,
                    hv_Column, ExpGetGlobalVar_gTitleDecor().TupleSelect(0), ExpGetGlobalVar_gTitleDecor().TupleSelect(
                    1));
            }
            hv_Information_COPY_INP_TMP = ("" + hv_Information_COPY_INP_TMP + "").TupleSplit(
                "\n");
            hv_NumInfoLines = new HTuple(hv_Information_COPY_INP_TMP.TupleLength());
            if ((int)new HTuple(hv_NumInfoLines.TupleGreater(0)) != 0)
            {
                if ((int)new HTuple(ExpGetGlobalVar_gInfoPos().TupleEqual("UpperLeft")) != 0)
                {
                    hv_Row = 12;
                    hv_Column = 12;
                }
                else if ((int)new HTuple(ExpGetGlobalVar_gInfoPos().TupleEqual("UpperRight")) != 0)
                {
                    if ((int)new HTuple(ExpGetGlobalVar_gInfoDecor().TupleSelect(1).TupleEqual(
                        "true")) != 0)
                    {
                        max_line_width(hv_WindowHandle, hv_Information_COPY_INP_TMP + "  ", out hv_TextWidth);
                    }
                    else
                    {
                        max_line_width(hv_WindowHandle, hv_Information_COPY_INP_TMP, out hv_TextWidth);
                    }
                    hv_Row = 12;
                    hv_Column = hv_WinWidth - hv_TextWidth - 12;
                }
                else if ((int)new HTuple(ExpGetGlobalVar_gInfoPos().TupleEqual("LowerLeft")) != 0)
                {
                    HOperatorSet.GetStringExtents(hv_ExpDefaultWinHandle, hv_Information_COPY_INP_TMP,
                        out hv_Ascent, out hv_Descent, out hv_Width, out hv_Height);
                    hv_Row = hv_WinHeight - (new HTuple(0).TupleMax2(hv_NumInfoLines - 1) * (hv_Ascent + hv_Descent) + hv_Height) - 12;
                    hv_Column = 12;
                }
                else
                {

                }
                disp_message(hv_ExpDefaultWinHandle, hv_Information_COPY_INP_TMP, "window",
                    hv_Row, hv_Column, ExpGetGlobalVar_gInfoDecor().TupleSelect(0), ExpGetGlobalVar_gInfoDecor().TupleSelect(
                    1));
            }
            //

            return;
        }

        // Chapter: Graphics / Output
        // Short Description: Renders 3D object models in a buffer window. 
        public void dump_image_output(HObject ho_BackgroundImage, HTuple hv_WindowHandleBuffer,
            HTuple hv_Scene3D, HTuple hv_AlphaOrig, HTuple hv_ObjectModel3DID, HTuple hv_GenParamName,
            HTuple hv_GenParamValue, HTuple hv_CamParam, HTuple hv_Poses, HTuple hv_ColorImage,
            HTuple hv_Title, HTuple hv_Information, HTuple hv_Labels, HTuple hv_VisualizeTrackball,
            HTuple hv_DisplayContinueButton, HTuple hv_TrackballCenterRow, HTuple hv_TrackballCenterCol,
            HTuple hv_TrackballRadiusPixel, HTuple hv_SelectedObject, HTuple hv_VisualizeRotationCenter,
            HTuple hv_RotationCenter)
        {




            // Local iconic variables 

            HObject ho_TrackballContour = null, ho_CrossRotCenter = null;
            HObject ho_ModelContours = null;

            // Local control variables 

            HTuple ExpTmpLocalVar_gUsesOpenGL = new HTuple();
            HTuple hv_Exception = new HTuple(), hv_Index = new HTuple();
            HTuple hv_Exception1 = new HTuple(), hv_DeselectedIdx = new HTuple();
            HTuple hv_DeselectedName = new HTuple(), hv_DeselectedValue = new HTuple();
            HTuple hv_Pose = new HTuple(), hv_HomMat3D = new HTuple();
            HTuple hv_Center = new HTuple(), hv_CenterCamX = new HTuple();
            HTuple hv_CenterCamY = new HTuple(), hv_CenterCamZ = new HTuple();
            HTuple hv_CenterRow = new HTuple(), hv_CenterCol = new HTuple();
            HTuple hv_Label = new HTuple(), hv_Ascent = new HTuple();
            HTuple hv_Descent = new HTuple(), hv_TextWidth = new HTuple();
            HTuple hv_TextHeight = new HTuple(), hv_RotCenterRow = new HTuple();
            HTuple hv_RotCenterCol = new HTuple(), hv_Orientation = new HTuple();
            HTuple hv_Colors = new HTuple();
            HTuple hv_RotationCenter_COPY_INP_TMP = hv_RotationCenter.Clone();

            // Initialize local and output iconic variables 
            HOperatorSet.GenEmptyObj(out ho_TrackballContour);
            HOperatorSet.GenEmptyObj(out ho_CrossRotCenter);
            HOperatorSet.GenEmptyObj(out ho_ModelContours);
            try
            {
                //global tuple gAlphaDeselected
                //global tuple gTerminationButtonLabel
                //global tuple gDispObjOffset
                //global tuple gLabelsDecor
                //global tuple gUsesOpenGL
                //
                //Display background image
                HOperatorSet.ClearWindow(hv_ExpDefaultWinHandle);
                if ((int)hv_ColorImage != 0)
                {
                    HOperatorSet.DispColor(ho_BackgroundImage, hv_ExpDefaultWinHandle);
                }
                else
                {
                    HOperatorSet.DispImage(ho_BackgroundImage, hv_ExpDefaultWinHandle);
                }
                //
                //Display objects
                if ((int)new HTuple(hv_SelectedObject.TupleSum().TupleEqual(new HTuple(hv_SelectedObject.TupleLength()
                    ))) != 0)
                {
                    if ((int)new HTuple(ExpGetGlobalVar_gUsesOpenGL().TupleEqual("true")) != 0)
                    {
                        try
                        {
                            HOperatorSet.DisplayScene3d(hv_ExpDefaultWinHandle, hv_Scene3D, 0);
                        }
                        // catch (Exception) 
                        catch (HalconException HDevExpDefaultException1)
                        {
                            HDevExpDefaultException1.ToHTuple(out hv_Exception);
                            if ((int)new HTuple(new HTuple(hv_Exception.TupleSelect(0).TupleEqual(
                                5185)).TupleOr(new HTuple(hv_Exception.TupleSelect(0).TupleEqual(
                                5188)))).TupleOr(new HTuple(hv_Exception.TupleSelect(0).TupleEqual(
                                5187))) != 0)
                            {
                                ExpTmpLocalVar_gUsesOpenGL = "false";
                                ExpSetGlobalVar_gUsesOpenGL(ExpTmpLocalVar_gUsesOpenGL);
                            }
                            else
                            {
                                throw new HalconException(hv_Exception);
                            }
                        }
                    }
                    if ((int)new HTuple(ExpGetGlobalVar_gUsesOpenGL().TupleEqual("false")) != 0)
                    {
                        //* NO OpenGL, use fallback
                        ho_ModelContours.Dispose();
                        disp_object_model_no_opengl(out ho_ModelContours, hv_ObjectModel3DID, hv_GenParamName,
                            hv_GenParamValue, hv_ExpDefaultWinHandle, hv_CamParam, hv_Poses);
                    }
                }
                else
                {
                    for (hv_Index = 0; (int)hv_Index <= (int)(new HTuple(hv_AlphaOrig.TupleLength()
                        ) - 1); hv_Index = (int)hv_Index + 1)
                    {
                        Application.DoEvents();
                        if ((int)new HTuple(hv_SelectedObject.TupleSelect(hv_Index).TupleEqual(
                            1)) != 0)
                        {
                            HOperatorSet.SetScene3dInstanceParam(hv_Scene3D, hv_Index, "alpha", hv_AlphaOrig.TupleSelect(
                                hv_Index));
                        }
                        else
                        {
                            HOperatorSet.SetScene3dInstanceParam(hv_Scene3D, hv_Index, "alpha", ExpGetGlobalVar_gAlphaDeselected());
                        }
                    }
                    try
                    {
                        if ((int)new HTuple(ExpGetGlobalVar_gUsesOpenGL().TupleEqual("false")) != 0)
                        {
                            throw new HalconException(new HTuple());
                        }
                        HOperatorSet.DisplayScene3d(hv_ExpDefaultWinHandle, hv_Scene3D, 0);
                    }
                    // catch (Exception1) 
                    catch (HalconException HDevExpDefaultException1)
                    {
                        HDevExpDefaultException1.ToHTuple(out hv_Exception1);
                        //* NO OpenGL, use fallback
                        hv_DeselectedIdx = hv_SelectedObject.TupleFind(0);
                        if ((int)new HTuple(hv_DeselectedIdx.TupleNotEqual(-1)) != 0)
                        {
                            hv_DeselectedName = "color_" + hv_DeselectedIdx;
                            hv_DeselectedValue = HTuple.TupleGenConst(new HTuple(hv_DeselectedName.TupleLength()
                                ), "gray");
                        }
                        ho_ModelContours.Dispose();
                        disp_object_model_no_opengl(out ho_ModelContours, hv_ObjectModel3DID, hv_GenParamName.TupleConcat(
                            hv_DeselectedName), hv_GenParamValue.TupleConcat(hv_DeselectedValue),
                            hv_ExpDefaultWinHandle, hv_CamParam, hv_Poses);
                    }
                    for (hv_Index = 0; (int)hv_Index <= (int)(new HTuple(hv_AlphaOrig.TupleLength()
                        ) - 1); hv_Index = (int)hv_Index + 1)
                    {
                        Application.DoEvents();
                        HOperatorSet.SetScene3dInstanceParam(hv_Scene3D, hv_Index, "alpha", hv_AlphaOrig.TupleSelect(
                            hv_Index));
                    }
                }
                //
                //Display labels
                if ((int)new HTuple(hv_Labels.TupleNotEqual(0)) != 0)
                {
                    HOperatorSet.SetColor(hv_ExpDefaultWinHandle, ExpGetGlobalVar_gLabelsDecor().TupleSelect(
                        0));
                    for (hv_Index = 0; (int)hv_Index <= (int)(new HTuple(hv_ObjectModel3DID.TupleLength()
                        ) - 1); hv_Index = (int)hv_Index + 1)
                    {
                        Application.DoEvents();
                        //Project the center point of the current model
                        hv_Pose = hv_Poses.TupleSelectRange(hv_Index * 7, hv_Index * 7 + 6);
                        HOperatorSet.PoseToHomMat3d(hv_Pose, out hv_HomMat3D);
                        HOperatorSet.GetObjectModel3dParams(hv_ObjectModel3DID.TupleSelect(hv_Index),
                            "center", out hv_Center);
                        HOperatorSet.AffineTransPoint3d(hv_HomMat3D, hv_Center.TupleSelect(0),
                            hv_Center.TupleSelect(1), hv_Center.TupleSelect(2), out hv_CenterCamX,
                            out hv_CenterCamY, out hv_CenterCamZ);
                        HOperatorSet.Project3dPoint(hv_CenterCamX, hv_CenterCamY, hv_CenterCamZ,
                            hv_CamParam, out hv_CenterRow, out hv_CenterCol);
                        hv_Label = hv_Labels.TupleSelect(hv_Index);
                        if ((int)new HTuple(hv_Label.TupleNotEqual("")) != 0)
                        {
                            HOperatorSet.GetStringExtents(hv_ExpDefaultWinHandle, hv_Label, out hv_Ascent,
                                out hv_Descent, out hv_TextWidth, out hv_TextHeight);
                            disp_message(hv_ExpDefaultWinHandle, hv_Label, "window", hv_CenterRow - hv_TextHeight / 2 + ExpGetGlobalVar_gDispObjOffset().TupleSelect(
                                0), hv_CenterCol - hv_TextWidth / 2 + ExpGetGlobalVar_gDispObjOffset().TupleSelect(
                                1), new HTuple(), ExpGetGlobalVar_gLabelsDecor().TupleSelect(1));
                        }
                    }
                }
                //
                //Visualize the trackball if desired
                if ((int)hv_VisualizeTrackball != 0)
                {
                    HOperatorSet.SetLineWidth(hv_ExpDefaultWinHandle, 1);
                    ho_TrackballContour.Dispose();
                    HOperatorSet.GenEllipseContourXld(out ho_TrackballContour, hv_TrackballCenterRow,
                        hv_TrackballCenterCol, 0, hv_TrackballRadiusPixel, hv_TrackballRadiusPixel,
                        0, 6.28318, "positive", 1.5);
                    HOperatorSet.SetColor(hv_ExpDefaultWinHandle, "dim gray");
                    HOperatorSet.DispXld(ho_TrackballContour, hv_ExpDefaultWinHandle);
                }
                //
                //Visualize the rotation center if desired
                if ((int)new HTuple(hv_VisualizeRotationCenter.TupleNotEqual(0)).TupleAnd(
                    new HTuple(new HTuple(hv_RotationCenter_COPY_INP_TMP.TupleLength()).TupleEqual(
                    3))) != 0)
                {
                    if ((int)new HTuple(hv_RotationCenter_COPY_INP_TMP.TupleSelect(2).TupleLess(
                        1e-10)) != 0)
                    {
                        if (hv_RotationCenter_COPY_INP_TMP == null)
                            hv_RotationCenter_COPY_INP_TMP = new HTuple();
                        hv_RotationCenter_COPY_INP_TMP[2] = 1e-10;
                    }
                    HOperatorSet.Project3dPoint(hv_RotationCenter_COPY_INP_TMP.TupleSelect(0),
                        hv_RotationCenter_COPY_INP_TMP.TupleSelect(1), hv_RotationCenter_COPY_INP_TMP.TupleSelect(
                        2), hv_CamParam, out hv_RotCenterRow, out hv_RotCenterCol);
                    hv_Orientation = new HTuple(90).TupleRad();
                    if ((int)new HTuple(hv_VisualizeRotationCenter.TupleEqual(1)) != 0)
                    {
                        hv_Orientation = new HTuple(45).TupleRad();
                    }
                    ho_CrossRotCenter.Dispose();
                    HOperatorSet.GenCrossContourXld(out ho_CrossRotCenter, hv_RotCenterRow, hv_RotCenterCol,
                        hv_TrackballRadiusPixel / 25.0, hv_Orientation);
                    HOperatorSet.SetLineWidth(hv_ExpDefaultWinHandle, 3);
                    HOperatorSet.QueryColor(hv_ExpDefaultWinHandle, out hv_Colors);
                    HOperatorSet.SetColor(hv_ExpDefaultWinHandle, "light gray");
                    HOperatorSet.DispXld(ho_CrossRotCenter, hv_ExpDefaultWinHandle);
                    HOperatorSet.SetLineWidth(hv_ExpDefaultWinHandle, 1);
                    HOperatorSet.SetColor(hv_ExpDefaultWinHandle, "dim gray");
                    HOperatorSet.DispXld(ho_CrossRotCenter, hv_ExpDefaultWinHandle);
                }
                //
                //Display title
                disp_title_and_information(hv_WindowHandleBuffer, hv_Title, hv_Information);
                //
                //Display the 'Exit' button

                //
                ho_TrackballContour.Dispose();
                ho_CrossRotCenter.Dispose();
                ho_ModelContours.Dispose();

                return;
            }
            catch (HalconException HDevExpDefaultException)
            {
                ho_TrackballContour.Dispose();
                ho_CrossRotCenter.Dispose();
                ho_ModelContours.Dispose();

                throw HDevExpDefaultException;
            }
        }

        // Chapter: Graphics / Output
        // Short Description: Compute the center of all given 3D object models. 
        public void get_object_models_center(HTuple hv_ObjectModel3DID, out HTuple hv_Center)
        {



            // Local iconic variables 

            // Local control variables 

            HTuple hv_Diameter = new HTuple(), hv_MD = new HTuple();
            HTuple hv_Weight = new HTuple(), hv_SumW = new HTuple();
            HTuple hv_Index = new HTuple(), hv_ObjectModel3DIDSelected = new HTuple();
            HTuple hv_C = new HTuple(), hv_InvSum = new HTuple();
            // Initialize local and output iconic variables 
            hv_Center = new HTuple();
            //Compute the mean of all model centers (weighted by the diameter of the object models)
            if ((int)new HTuple(new HTuple(hv_ObjectModel3DID.TupleLength()).TupleGreater(
                0)) != 0)
            {
                HOperatorSet.GetObjectModel3dParams(hv_ObjectModel3DID, "diameter_axis_aligned_bounding_box",
                    out hv_Diameter);
                //Normalize Diameter to use it as weights for a weighted mean of the individual centers
                hv_MD = hv_Diameter.TupleMean();
                if ((int)new HTuple(hv_MD.TupleGreater(1e-10)) != 0)
                {
                    hv_Weight = hv_Diameter / hv_MD;
                }
                else
                {
                    hv_Weight = hv_Diameter.Clone();
                }
                hv_SumW = hv_Weight.TupleSum();
                if ((int)new HTuple(hv_SumW.TupleLess(1e-10)) != 0)
                {
                    hv_Weight = HTuple.TupleGenConst(new HTuple(hv_Weight.TupleLength()), 1.0);
                    hv_SumW = hv_Weight.TupleSum();
                }
                hv_Center = new HTuple();
                hv_Center[0] = 0;
                hv_Center[1] = 0;
                hv_Center[2] = 0;
                for (hv_Index = 0; (int)hv_Index <= (int)(new HTuple(hv_ObjectModel3DID.TupleLength()
                    ) - 1); hv_Index = (int)hv_Index + 1)
                {
                    Application.DoEvents();
                    hv_ObjectModel3DIDSelected = hv_ObjectModel3DID.TupleSelect(hv_Index);
                    HOperatorSet.GetObjectModel3dParams(hv_ObjectModel3DIDSelected, "center",
                        out hv_C);
                    if (hv_Center == null)
                        hv_Center = new HTuple();
                    hv_Center[0] = hv_Center.TupleSelect(0) + hv_C.TupleSelect(0) * hv_Weight.TupleSelect(
                        hv_Index);
                    if (hv_Center == null)
                        hv_Center = new HTuple();
                    hv_Center[1] = hv_Center.TupleSelect(1) + hv_C.TupleSelect(1) * hv_Weight.TupleSelect(
                        hv_Index);
                    if (hv_Center == null)
                        hv_Center = new HTuple();
                    hv_Center[2] = hv_Center.TupleSelect(2) + hv_C.TupleSelect(2) * hv_Weight.TupleSelect(
                        hv_Index);
                }
                hv_InvSum = 1.0 / hv_SumW;
                if (hv_Center == null)
                    hv_Center = new HTuple();
                hv_Center[0] = hv_Center.TupleSelect(0) * hv_InvSum;
                if (hv_Center == null)
                    hv_Center = new HTuple();
                hv_Center[1] = hv_Center.TupleSelect(1) * hv_InvSum;
                if (hv_Center == null)
                    hv_Center = new HTuple();
                hv_Center[2] = hv_Center.TupleSelect(2) * hv_InvSum;
            }
            else
            {
                hv_Center = new HTuple();
            }

            return;
        }

        // Chapter: Graphics / Output
        // Short Description: Get the center of the virtual trackback that is used to move the camera. 
        public void get_trackball_center(HTuple hv_SelectedObject, HTuple hv_TrackballRadiusPixel,
            HTuple hv_ObjectModel3D, HTuple hv_Poses, out HTuple hv_TBCenter, out HTuple hv_TBSize)
        {



            // Local iconic variables 

            // Local control variables 

            HTuple hv_NumModels = null, hv_Centers = null;
            HTuple hv_Diameter = null, hv_MD = null, hv_Weight = new HTuple();
            HTuple hv_SumW = null, hv_Index = null, hv_ObjectModel3DIDSelected = new HTuple();
            HTuple hv_PoseSelected = new HTuple(), hv_HomMat3D = new HTuple();
            HTuple hv_TBCenterCamX = new HTuple(), hv_TBCenterCamY = new HTuple();
            HTuple hv_TBCenterCamZ = new HTuple(), hv_InvSum = new HTuple();
            // Initialize local and output iconic variables 
            hv_TBCenter = new HTuple();
            hv_TBSize = new HTuple();
            hv_NumModels = new HTuple(hv_ObjectModel3D.TupleLength());
            if (hv_TBCenter == null)
                hv_TBCenter = new HTuple();
            hv_TBCenter[0] = 0;
            if (hv_TBCenter == null)
                hv_TBCenter = new HTuple();
            hv_TBCenter[1] = 0;
            if (hv_TBCenter == null)
                hv_TBCenter = new HTuple();
            hv_TBCenter[2] = 0;
            HOperatorSet.GetObjectModel3dParams(hv_ObjectModel3D, "center", out hv_Centers);
            HOperatorSet.GetObjectModel3dParams(hv_ObjectModel3D, "diameter_axis_aligned_bounding_box",
                out hv_Diameter);
            //Normalize Diameter to use it as weights for a weighted mean of the individual centers
            hv_MD = hv_Diameter.TupleMean();
            if ((int)new HTuple(hv_MD.TupleGreater(1e-10)) != 0)
            {
                hv_Weight = hv_Diameter / hv_MD;
            }
            else
            {
                hv_Weight = hv_Diameter.Clone();
            }
            hv_SumW = hv_Weight.TupleSelectMask(hv_SelectedObject.TupleSgn().TupleAbs()
                ).TupleSum();
            if ((int)new HTuple(hv_SumW.TupleLess(1e-10)) != 0)
            {
                hv_Weight = HTuple.TupleGenConst(new HTuple(hv_Weight.TupleLength()), 1.0);
                hv_SumW = hv_Weight.TupleSelectMask(hv_SelectedObject.TupleSgn().TupleAbs()
                    ).TupleSum();
            }
            HTuple end_val18 = hv_NumModels - 1;
            HTuple step_val18 = 1;
            for (hv_Index = 0; hv_Index.Continue(end_val18, step_val18); hv_Index = hv_Index.TupleAdd(step_val18))
            {
                Application.DoEvents();
                if ((int)hv_SelectedObject.TupleSelect(hv_Index) != 0)
                {
                    hv_ObjectModel3DIDSelected = hv_ObjectModel3D.TupleSelect(hv_Index);
                    hv_PoseSelected = hv_Poses.TupleSelectRange(hv_Index * 7, hv_Index * 7 + 6);
                    HOperatorSet.PoseToHomMat3d(hv_PoseSelected, out hv_HomMat3D);
                    HOperatorSet.AffineTransPoint3d(hv_HomMat3D, hv_Centers.TupleSelect(hv_Index * 3 + 0),
                        hv_Centers.TupleSelect(hv_Index * 3 + 1), hv_Centers.TupleSelect(hv_Index * 3 + 2),
                        out hv_TBCenterCamX, out hv_TBCenterCamY, out hv_TBCenterCamZ);
                    if (hv_TBCenter == null)
                        hv_TBCenter = new HTuple();
                    hv_TBCenter[0] = hv_TBCenter.TupleSelect(0) + hv_TBCenterCamX * hv_Weight.TupleSelect(
                        hv_Index);
                    if (hv_TBCenter == null)
                        hv_TBCenter = new HTuple();
                    hv_TBCenter[1] = hv_TBCenter.TupleSelect(1) + hv_TBCenterCamY * hv_Weight.TupleSelect(
                        hv_Index);
                    if (hv_TBCenter == null)
                        hv_TBCenter = new HTuple();
                    hv_TBCenter[2] = hv_TBCenter.TupleSelect(2) + hv_TBCenterCamZ * hv_Weight.TupleSelect(
                        hv_Index);
                }
            }
            if ((int)new HTuple(hv_SelectedObject.TupleMax().TupleNotEqual(0)) != 0)
            {
                hv_InvSum = 1.0 / hv_SumW;
                if (hv_TBCenter == null)
                    hv_TBCenter = new HTuple();
                hv_TBCenter[0] = hv_TBCenter.TupleSelect(0) * hv_InvSum;
                if (hv_TBCenter == null)
                    hv_TBCenter = new HTuple();
                hv_TBCenter[1] = hv_TBCenter.TupleSelect(1) * hv_InvSum;
                if (hv_TBCenter == null)
                    hv_TBCenter = new HTuple();
                hv_TBCenter[2] = hv_TBCenter.TupleSelect(2) * hv_InvSum;
                hv_TBSize = (0.5 + 0.5 * hv_SelectedObject.TupleSum() / hv_NumModels) * hv_TrackballRadiusPixel;
            }
            else
            {
                hv_TBCenter = new HTuple();
                hv_TBSize = 0;
            }

            return;
        }

        // Chapter: Graphics / Output
        // Short Description: Get the center of the virtual trackback that is used to move the camera (version for inspection_mode = 'surface'). 
        public void get_trackball_center_fixed(HTuple hv_SelectedObject, HTuple hv_TrackballCenterRow,
            HTuple hv_TrackballCenterCol, HTuple hv_TrackballRadiusPixel, HTuple hv_Scene3D,
            HTuple hv_ObjectModel3DID, HTuple hv_Poses, HTuple hv_WindowHandleBuffer, HTuple hv_CamParam,
            HTuple hv_GenParamName, HTuple hv_GenParamValue, out HTuple hv_TBCenter, out HTuple hv_TBSize)
        {



            // Local iconic variables 

            HObject ho_RegionCenter, ho_DistanceImage;
            HObject ho_Domain;

            // Local control variables 

            HTuple hv_NumModels = null, hv_Width = null;
            HTuple hv_Height = null, hv_SelectPose = null, hv_Index1 = null;
            HTuple hv_Rows = null, hv_Columns = null, hv_Grayval = null;
            HTuple hv_IndicesG = null, hv_Value = null, hv_Pos = null;
            // Initialize local and output iconic variables 
            HOperatorSet.GenEmptyObj(out ho_RegionCenter);
            HOperatorSet.GenEmptyObj(out ho_DistanceImage);
            HOperatorSet.GenEmptyObj(out ho_Domain);
            hv_TBCenter = new HTuple();
            hv_TBSize = new HTuple();
            try
            {
                //Determine the trackball center for the fixed trackball
                hv_NumModels = new HTuple(hv_ObjectModel3DID.TupleLength());
                get_cam_par_data(hv_CamParam, "image_width", out hv_Width);
                get_cam_par_data(hv_CamParam, "image_height", out hv_Height);
                //
                //Project the selected objects
                hv_SelectPose = new HTuple();
                for (hv_Index1 = 0; (int)hv_Index1 <= (int)(new HTuple(hv_SelectedObject.TupleLength()
                    ) - 1); hv_Index1 = (int)hv_Index1 + 1)
                {
                    Application.DoEvents();
                    hv_SelectPose = hv_SelectPose.TupleConcat(HTuple.TupleGenConst(7, hv_SelectedObject.TupleSelect(
                        hv_Index1)));
                    if ((int)new HTuple(hv_SelectedObject.TupleSelect(hv_Index1).TupleEqual(
                        0)) != 0)
                    {
                        HOperatorSet.SetScene3dInstanceParam(hv_Scene3D, hv_Index1, "visible",
                            "false");
                    }
                }
                HOperatorSet.SetScene3dParam(hv_Scene3D, "depth_persistence", "true");
                HOperatorSet.DisplayScene3d(hv_ExpDefaultWinHandle, hv_Scene3D, 0);
                HOperatorSet.SetScene3dParam(hv_Scene3D, "visible", "true");
                //
                //determine the depth of the object point that appears closest to the trackball
                //center
                ho_RegionCenter.Dispose();
                HOperatorSet.GenRegionPoints(out ho_RegionCenter, hv_TrackballCenterRow, hv_TrackballCenterCol);
                ho_DistanceImage.Dispose();
                HOperatorSet.DistanceTransform(ho_RegionCenter, out ho_DistanceImage, "chamfer-3-4-unnormalized",
                    "false", hv_Width, hv_Height);
                ho_Domain.Dispose();
                HOperatorSet.GetDomain(ho_DistanceImage, out ho_Domain);
                HOperatorSet.GetRegionPoints(ho_Domain, out hv_Rows, out hv_Columns);
                HOperatorSet.GetGrayval(ho_DistanceImage, hv_Rows, hv_Columns, out hv_Grayval);
                HOperatorSet.TupleSortIndex(hv_Grayval, out hv_IndicesG);
                HOperatorSet.GetDisplayScene3dInfo(hv_ExpDefaultWinHandle, hv_Scene3D, hv_Rows.TupleSelect(
                    hv_IndicesG), hv_Columns.TupleSelect(hv_IndicesG), "depth", out hv_Value);
                HOperatorSet.TupleFind(hv_Value.TupleSgn(), 1, out hv_Pos);
                //
                HOperatorSet.SetScene3dParam(hv_Scene3D, "depth_persistence", "false");
                //
                //
                //set TBCenter
                if ((int)new HTuple(hv_Pos.TupleNotEqual(-1)) != 0)
                {
                    //if the object is visible in the image
                    hv_TBCenter = new HTuple();
                    hv_TBCenter[0] = 0;
                    hv_TBCenter[1] = 0;
                    hv_TBCenter = hv_TBCenter.TupleConcat(hv_Value.TupleSelect(
                        hv_Pos.TupleSelect(0)));
                }
                else
                {
                    //if the object is not visible in the image, set the z coordinate to -1
                    //to indicate, the the previous z value should be used instead
                    hv_TBCenter = new HTuple();
                    hv_TBCenter[0] = 0;
                    hv_TBCenter[1] = 0;
                    hv_TBCenter[2] = -1;
                }
                //
                if ((int)new HTuple(hv_SelectedObject.TupleMax().TupleNotEqual(0)) != 0)
                {
                    hv_TBSize = (0.5 + 0.5 * hv_SelectedObject.TupleSum() / hv_NumModels) * hv_TrackballRadiusPixel;
                }
                else
                {
                    hv_TBCenter = new HTuple();
                    hv_TBSize = 0;
                }
                ho_RegionCenter.Dispose();
                ho_DistanceImage.Dispose();
                ho_Domain.Dispose();

                return;
            }
            catch (HalconException HDevExpDefaultException)
            {
                ho_RegionCenter.Dispose();
                ho_DistanceImage.Dispose();
                ho_Domain.Dispose();

                throw HDevExpDefaultException;
            }
        }

        // Chapter: Graphics / Output
        // Short Description: Get string extends of several lines. 
        public void max_line_width(HTuple hv_WindowHandle, HTuple hv_Lines, out HTuple hv_MaxWidth)
        {



            // Local iconic variables 

            // Local control variables 

            HTuple hv_Index = null, hv_Ascent = new HTuple();
            HTuple hv_Descent = new HTuple(), hv_LineWidth = new HTuple();
            HTuple hv_LineHeight = new HTuple();
            // Initialize local and output iconic variables 
            hv_MaxWidth = 0;
            for (hv_Index = 0; (int)hv_Index <= (int)(new HTuple(hv_Lines.TupleLength()) - 1); hv_Index = (int)hv_Index + 1)
            {
                Application.DoEvents();
                HOperatorSet.GetStringExtents(hv_ExpDefaultWinHandle, hv_Lines.TupleSelect(
                    hv_Index), out hv_Ascent, out hv_Descent, out hv_LineWidth, out hv_LineHeight);
                hv_MaxWidth = hv_LineWidth.TupleConcat(hv_MaxWidth).TupleMax();
            }

            return;
        }

        // Chapter: Graphics / Output
        // Short Description: Project an image point onto the trackball 
        public void project_point_on_trackball(HTuple hv_X, HTuple hv_Y, HTuple hv_VirtualTrackball,
            HTuple hv_TrackballSize, out HTuple hv_V)
        {



            // Local iconic variables 

            // Local control variables 

            HTuple hv_R = new HTuple(), hv_XP = new HTuple();
            HTuple hv_YP = new HTuple(), hv_ZP = new HTuple();
            // Initialize local and output iconic variables 
            if ((int)new HTuple(hv_VirtualTrackball.TupleEqual("shoemake")) != 0)
            {
                //Virtual Trackball according to Shoemake
                hv_R = (hv_X * hv_X + hv_Y * hv_Y).TupleSqrt();
                if ((int)new HTuple(hv_R.TupleLessEqual(hv_TrackballSize)) != 0)
                {
                    hv_XP = hv_X.Clone();
                    hv_YP = hv_Y.Clone();
                    hv_ZP = (hv_TrackballSize * hv_TrackballSize - hv_R * hv_R).TupleSqrt();
                }
                else
                {
                    hv_XP = hv_X * hv_TrackballSize / hv_R;
                    hv_YP = hv_Y * hv_TrackballSize / hv_R;
                    hv_ZP = 0;
                }
            }
            else
            {
                //Virtual Trackball according to Bell
                hv_R = (hv_X * hv_X + hv_Y * hv_Y).TupleSqrt();
                if ((int)new HTuple(hv_R.TupleLessEqual(hv_TrackballSize * 0.70710678)) != 0)
                {
                    hv_XP = hv_X.Clone();
                    hv_YP = hv_Y.Clone();
                    hv_ZP = (hv_TrackballSize * hv_TrackballSize - hv_R * hv_R).TupleSqrt();
                }
                else
                {
                    hv_XP = hv_X.Clone();
                    hv_YP = hv_Y.Clone();
                    hv_ZP = 0.6 * hv_TrackballSize * hv_TrackballSize / hv_R;
                }
            }
            hv_V = new HTuple();
            hv_V = hv_V.TupleConcat(hv_XP);
            hv_V = hv_V.TupleConcat(hv_YP);
            hv_V = hv_V.TupleConcat(hv_ZP);

            return;
        }

        // Chapter: Graphics / Output
        // Short Description: Compute the 3D rotation from the mouse movement 
        public void trackball(HTuple hv_MX1, HTuple hv_MY1, HTuple hv_MX2, HTuple hv_MY2,
            HTuple hv_VirtualTrackball, HTuple hv_TrackballSize, HTuple hv_SensFactor, out HTuple hv_QuatRotation)
        {



            // Local iconic variables 

            // Local control variables 

            HTuple hv_P1 = null, hv_P2 = null, hv_RotAxis = null;
            HTuple hv_D = null, hv_T = null, hv_RotAngle = null, hv_Len = null;
            // Initialize local and output iconic variables 
            hv_QuatRotation = new HTuple();
            //Compute the 3D rotation from the mouse movement
            //
            if ((int)new HTuple(hv_MX1.TupleEqual(hv_MX2)).TupleAnd(new HTuple(hv_MY1.TupleEqual(
                hv_MY2))) != 0)
            {
                hv_QuatRotation = new HTuple();
                hv_QuatRotation[0] = 1;
                hv_QuatRotation[1] = 0;
                hv_QuatRotation[2] = 0;
                hv_QuatRotation[3] = 0;

                return;
            }
            //Project the image point onto the trackball
            project_point_on_trackball(hv_MX1, hv_MY1, hv_VirtualTrackball, hv_TrackballSize,
                out hv_P1);
            project_point_on_trackball(hv_MX2, hv_MY2, hv_VirtualTrackball, hv_TrackballSize,
                out hv_P2);
            //The cross product of the projected points defines the rotation axis
            tuple_vector_cross_product(hv_P1, hv_P2, out hv_RotAxis);
            //Compute the rotation angle
            hv_D = hv_P2 - hv_P1;
            hv_T = (hv_D * hv_D).TupleSum().TupleSqrt() / (2.0 * hv_TrackballSize);
            if ((int)new HTuple(hv_T.TupleGreater(1.0)) != 0)
            {
                hv_T = 1.0;
            }
            if ((int)new HTuple(hv_T.TupleLess(-1.0)) != 0)
            {
                hv_T = -1.0;
            }
            hv_RotAngle = 2.0 * hv_T.TupleAsin() * hv_SensFactor;
            hv_Len = (hv_RotAxis * hv_RotAxis).TupleSum().TupleSqrt();
            if ((int)new HTuple(hv_Len.TupleGreater(0.0)) != 0)
            {
                hv_RotAxis = hv_RotAxis / hv_Len;
            }
            HOperatorSet.AxisAngleToQuat(hv_RotAxis.TupleSelect(0), hv_RotAxis.TupleSelect(
                1), hv_RotAxis.TupleSelect(2), hv_RotAngle, out hv_QuatRotation);

            return;
        }

        // Chapter: Tuple / Arithmetic
        // Short Description: Calculates the cross product of two vectors of length 3. 
        public void tuple_vector_cross_product(HTuple hv_V1, HTuple hv_V2, out HTuple hv_VC)
        {



            // Local iconic variables 
            // Initialize local and output iconic variables 
            //The caller must ensure that the length of both input vectors is 3
            hv_VC = hv_V1.TupleSelect(1) * hv_V2.TupleSelect(2) - hv_V1.TupleSelect(2) * hv_V2.TupleSelect(
                1);
            hv_VC = hv_VC.TupleConcat(hv_V1.TupleSelect(2) * hv_V2.TupleSelect(0) - hv_V1.TupleSelect(
                0) * hv_V2.TupleSelect(2));
            hv_VC = hv_VC.TupleConcat(hv_V1.TupleSelect(0) * hv_V2.TupleSelect(1) - hv_V1.TupleSelect(
                1) * hv_V2.TupleSelect(0));

            return;
        }

        // Chapter: Graphics / Output
        // Short Description: Interactively display 3D object models 
        public void visualize_object_model_3d(HTuple hv_WindowHandle, HTuple hv_ObjectModel3D,
            HTuple hv_CamParam, HTuple hv_PoseIn, HTuple hv_GenParamName, HTuple hv_GenParamValue,
            HTuple hv_Title, HTuple hv_Label, HTuple hv_Information, out HTuple hv_PoseOut)
        {



            // Local iconic variables 

            HObject ho_Image = null, ho_ImageDump = null;

            // Local control variables 

            HTuple ExpTmpLocalVar_gDispObjOffset = null;
            HTuple ExpTmpLocalVar_gLabelsDecor = null, ExpTmpLocalVar_gInfoDecor = null;
            HTuple ExpTmpLocalVar_gInfoPos = null, ExpTmpLocalVar_gTitlePos = null;
            HTuple ExpTmpLocalVar_gTitleDecor = null, ExpTmpLocalVar_gTerminationButtonLabel = null;
            HTuple ExpTmpLocalVar_gAlphaDeselected = null, ExpTmpLocalVar_gIsSinglePose = new HTuple();
            HTuple ExpTmpLocalVar_gUsesOpenGL = new HTuple(), hv_Scene3DTest = null;
            HTuple hv_Scene3D = null, hv_WindowHandleBuffer = new HTuple();
            HTuple hv_TrackballSize = null, hv_VirtualTrackball = null;
            HTuple hv_MouseMapping = null, hv_WaitForButtonRelease = null;
            HTuple hv_MaxNumModels = null, hv_WindowCenteredRotation = null;
            HTuple hv_NumModels = null, hv_SelectedObject = null, hv_ClipRegion = null;
            HTuple hv_CPLength = new HTuple(), hv_RowNotUsed = new HTuple();
            HTuple hv_ColumnNotUsed = new HTuple(), hv_Width = new HTuple();
            HTuple hv_Height = new HTuple(), hv_WPRow1 = new HTuple();
            HTuple hv_WPColumn1 = new HTuple(), hv_WPRow2 = new HTuple();
            HTuple hv_WPColumn2 = new HTuple(), hv_CamParamValue = new HTuple();
            HTuple hv_CamWidth = new HTuple(), hv_CamHeight = new HTuple();
            HTuple hv_Scale = new HTuple(), hv_Indices = new HTuple();
            HTuple hv_DispBackground = new HTuple(), hv_Mask = new HTuple();
            HTuple hv_Center = new HTuple(), hv_Poses = new HTuple();
            HTuple hv_HomMat3Ds = new HTuple(), hv_Sequence = new HTuple();
            HTuple hv_PoseEstimated = new HTuple(), hv_Font = new HTuple();
            HTuple hv_Exception = new HTuple(), hv_OpenGLInfo = new HTuple();
            HTuple hv_DummyObjectModel3D = new HTuple(), hv_CameraIndexTest = new HTuple();
            HTuple hv_PoseTest = new HTuple(), hv_InstanceIndexTest = new HTuple();
            HTuple hv_MinImageSize = new HTuple(), hv_TrackballRadiusPixel = new HTuple();
            HTuple hv_Ascent = new HTuple(), hv_Descent = new HTuple();
            HTuple hv_TextWidth = new HTuple(), hv_TextHeight = new HTuple();
            HTuple hv_NumChannels = new HTuple(), hv_ColorImage = new HTuple();
            HTuple hv_CameraIndex = new HTuple(), hv_AllInstances = new HTuple();
            HTuple hv_SetLight = new HTuple(), hv_LightParam = new HTuple();
            HTuple hv_LightPosition = new HTuple(), hv_LightKind = new HTuple();
            HTuple hv_LightIndex = new HTuple(), hv_PersistenceParamName = new HTuple();
            HTuple hv_PersistenceParamValue = new HTuple(), hv_AlphaOrig = new HTuple();
            HTuple hv_I = new HTuple(), hv_ParamName = new HTuple();
            HTuple hv_ParamValue = new HTuple(), hv_ParamNameTrunk = new HTuple();
            HTuple hv_Instance = new HTuple(), hv_HomMat3D = new HTuple();
            HTuple hv_Qx = new HTuple(), hv_Qy = new HTuple(), hv_Qz = new HTuple();
            HTuple hv_TBCenter = new HTuple(), hv_TBSize = new HTuple();
            HTuple hv_ButtonHold = new HTuple(), hv_VisualizeTB = new HTuple();
            HTuple hv_MaxIndex = new HTuple(), hv_TrackballCenterRow = new HTuple();
            HTuple hv_TrackballCenterCol = new HTuple(), hv_GraphEvent = new HTuple();
            HTuple hv_Exit = new HTuple(), hv_GraphButtonRow = new HTuple();
            HTuple hv_GraphButtonColumn = new HTuple(), hv_GraphButton = new HTuple();
            HTuple hv_ButtonReleased = new HTuple(), hv_e = new HTuple();
            HTuple hv_CamParam_COPY_INP_TMP = hv_CamParam.Clone();
            HTuple hv_GenParamName_COPY_INP_TMP = hv_GenParamName.Clone();
            HTuple hv_GenParamValue_COPY_INP_TMP = hv_GenParamValue.Clone();
            HTuple hv_Label_COPY_INP_TMP = hv_Label.Clone();
            HTuple hv_PoseIn_COPY_INP_TMP = hv_PoseIn.Clone();

            // Initialize local and output iconic variables 
            HOperatorSet.GenEmptyObj(out ho_Image);
            HOperatorSet.GenEmptyObj(out ho_ImageDump);
            hv_PoseOut = new HTuple();
            try
            {

                //**********************************************************
                //Initialize Handles to enable correct handling in error case
                //**********************************************************
                hv_Scene3DTest = new HTuple();
                hv_Scene3D = new HTuple();
                hv_WindowHandleBuffer = new HTuple();

                //**********************************************************
                //Some user defines that may be adapted if desired
                //**********************************************************
                //
                //TrackballSize defines the diameter of the trackball in
                //the image with respect to the smaller image dimension.
                hv_TrackballSize = 0.8;
                //
                //VirtualTrackball defines the type of virtual trackball that
                //shall be used ('shoemake' or 'bell').
                hv_VirtualTrackball = "shoemake";
                //VirtualTrackball := 'bell'
                //
                //Functionality of mouse buttons
                //    1: Left Button
                //    2: Middle Button
                //    4: Right Button
                //    5: Left+Right Mousebutton
                //  8+x: Shift + Mousebutton
                // 16+x: Ctrl + Mousebutton
                // 48+x: Ctrl + Alt + Mousebutton
                //in the order [Translate, Rotate, Scale, ScaleAlternative1, ScaleAlternative2, SelectObjects, ToggleSelectionMode]
                hv_MouseMapping = new HTuple();
                hv_MouseMapping[0] = 17;
                hv_MouseMapping[1] = 1;
                hv_MouseMapping[2] = 2;
                hv_MouseMapping[3] = 5;
                hv_MouseMapping[4] = 9;
                hv_MouseMapping[5] = 4;
                hv_MouseMapping[6] = 49;
                //
                //The labels of the objects appear next to their projected
                //center. With gDispObjOffset a fixed offset is added
                //                  R,  C
                ExpTmpLocalVar_gDispObjOffset = new HTuple();
                ExpTmpLocalVar_gDispObjOffset[0] = -30;
                ExpTmpLocalVar_gDispObjOffset[1] = 0;
                ExpSetGlobalVar_gDispObjOffset(ExpTmpLocalVar_gDispObjOffset);
                //
                //Customize the decoration of the different text elements
                //              Color,   Box
                ExpTmpLocalVar_gInfoDecor = new HTuple();
                ExpTmpLocalVar_gInfoDecor[0] = "white";
                ExpTmpLocalVar_gInfoDecor[1] = "false";
                ExpSetGlobalVar_gInfoDecor(ExpTmpLocalVar_gInfoDecor);
                ExpTmpLocalVar_gLabelsDecor = new HTuple();
                ExpTmpLocalVar_gLabelsDecor[0] = "white";
                ExpTmpLocalVar_gLabelsDecor[1] = "false";
                ExpSetGlobalVar_gLabelsDecor(ExpTmpLocalVar_gLabelsDecor);
                ExpTmpLocalVar_gTitleDecor = new HTuple();
                ExpTmpLocalVar_gTitleDecor[0] = "black";
                ExpTmpLocalVar_gTitleDecor[1] = "true";
                ExpSetGlobalVar_gTitleDecor(ExpTmpLocalVar_gTitleDecor);
                //
                //Customize the position of some text elements
                //  gInfoPos has one of the values
                //  {'UpperLeft', 'LowerLeft', 'UpperRight'}
                ExpTmpLocalVar_gInfoPos = "LowerLeft";
                ExpSetGlobalVar_gInfoPos(ExpTmpLocalVar_gInfoPos);
                //  gTitlePos has one of the values
                //  {'UpperLeft', 'UpperCenter', 'UpperRight'}
                ExpTmpLocalVar_gTitlePos = "UpperLeft";
                ExpSetGlobalVar_gTitlePos(ExpTmpLocalVar_gTitlePos);
                //Alpha value (=1-transparency) that is used for visualizing
                //the objects that are not selected
                ExpTmpLocalVar_gAlphaDeselected = 0.3;
                ExpSetGlobalVar_gAlphaDeselected(ExpTmpLocalVar_gAlphaDeselected);
                //Customize the label of the continue button
                ExpTmpLocalVar_gTerminationButtonLabel = " Continue ";
                ExpSetGlobalVar_gTerminationButtonLabel(ExpTmpLocalVar_gTerminationButtonLabel);
                //Define if the continue button responds to a single click event or
                //if it responds only if the mouse button is released while being placed
                //over the continue button.
                //'true':  Wait until the continue button has been released.
                //         This should be used to avoid unwanted continuations of
                //         subsequent calls of visualize_object_model_3d, which can
                //         otherwise occur if the mouse button remains pressed while the
                //         next visualization is active.
                //'false': Continue the execution already if the continue button is
                //         pressed. This option allows a fast forwarding through
                //         subsequent calls of visualize_object_model_3d.
                hv_WaitForButtonRelease = "true";
                //Number of 3D Object models that can be selected and handled individually.
                //If there are more models passed then this number, some calculations
                //are performed differently and the individual selection and handling
                //of models is not supported anymore. Note that the value of MaxNumModels
                //can be overwritten with the generic parameter max_num_selectable_models.
                hv_MaxNumModels = 1000;
                //Defines the default for the initial state of the rotation center:
                //(1) The rotation center is fixed in the center of the image and lies
                //    on the surface of the object.
                //(2) The rotation center lies in the center of the object.
                hv_WindowCenteredRotation = 2;
                //
                //**********************************************************
                //
                //Initialize some values
                hv_NumModels = new HTuple(hv_ObjectModel3D.TupleLength());
                hv_SelectedObject = HTuple.TupleGenConst(hv_NumModels, 1);
                //
                //Apply some system settings
                // dev_set_preferences(...); only in hdevelop
                // dev_get_preferences(...); only in hdevelop
                // dev_set_preferences(...); only in hdevelop
                // dev_get_preferences(...); only in hdevelop
                // dev_set_preferences(...); only in hdevelop
                HOperatorSet.GetSystem("clip_region", out hv_ClipRegion);
                HOperatorSet.SetSystem("clip_region", "false");
                dev_update_off();
                //
                //Check if GenParamName matches GenParamValue
                if ((int)new HTuple(new HTuple(hv_GenParamName_COPY_INP_TMP.TupleLength()
                    ).TupleNotEqual(new HTuple(hv_GenParamValue_COPY_INP_TMP.TupleLength()
                    ))) != 0)
                {
                    throw new HalconException("Number of generic parameters does not match number of generic parameter values");
                }
                //
                try
                {
                    //
                    //Refactor camera parameters to fit to window size
                    //
                    hv_CPLength = new HTuple(hv_CamParam_COPY_INP_TMP.TupleLength());
                    HOperatorSet.GetWindowExtents(hv_ExpDefaultWinHandle, out hv_RowNotUsed,
                        out hv_ColumnNotUsed, out hv_Width, out hv_Height);
                    HOperatorSet.GetPart(hv_ExpDefaultWinHandle, out hv_WPRow1, out hv_WPColumn1,
                        out hv_WPRow2, out hv_WPColumn2);
                    HOperatorSet.SetPart(hv_ExpDefaultWinHandle, 0, 0, hv_Height - 1, hv_Width - 1);
                    if ((int)new HTuple(hv_CPLength.TupleEqual(0)) != 0)
                    {
                        gen_cam_par_area_scan_division(0.06, 0, 8.5e-6, 8.5e-6, hv_Width / 2, hv_Height / 2,
                            hv_Width, hv_Height, out hv_CamParam_COPY_INP_TMP);
                    }
                    else
                    {
                        get_cam_par_data(hv_CamParam_COPY_INP_TMP, new HTuple("sx").TupleConcat(
                            "sy").TupleConcat("cx").TupleConcat("cy").TupleConcat("image_width").TupleConcat(
                            "image_height"), out hv_CamParamValue);
                        hv_CamWidth = hv_CamParamValue.TupleSelect(4).TupleReal();
                        hv_CamHeight = hv_CamParamValue.TupleSelect(5).TupleReal();
                        hv_Scale = (hv_Width / hv_CamWidth).TupleConcat(hv_Height / hv_CamHeight).TupleMin()
                            ;
                        set_cam_par_data(hv_CamParam_COPY_INP_TMP, "sx", hv_CamParamValue.TupleSelect(
                            0) / hv_Scale, out hv_CamParam_COPY_INP_TMP);
                        set_cam_par_data(hv_CamParam_COPY_INP_TMP, "sy", hv_CamParamValue.TupleSelect(
                            1) / hv_Scale, out hv_CamParam_COPY_INP_TMP);
                        set_cam_par_data(hv_CamParam_COPY_INP_TMP, "cx", hv_CamParamValue.TupleSelect(
                            2) * hv_Scale, out hv_CamParam_COPY_INP_TMP);
                        set_cam_par_data(hv_CamParam_COPY_INP_TMP, "cy", hv_CamParamValue.TupleSelect(
                            3) * hv_Scale, out hv_CamParam_COPY_INP_TMP);
                        set_cam_par_data(hv_CamParam_COPY_INP_TMP, "image_width", (hv_CamParamValue.TupleSelect(
                            4) * hv_Scale).TupleInt(), out hv_CamParam_COPY_INP_TMP);
                        set_cam_par_data(hv_CamParam_COPY_INP_TMP, "image_height", (hv_CamParamValue.TupleSelect(
                            5) * hv_Scale).TupleInt(), out hv_CamParam_COPY_INP_TMP);
                    }
                    //
                    //Check the generic parameters for max_num_selectable_models
                    //(Note that the default is set above to MaxNumModels := 1000)
                    hv_Indices = hv_GenParamName_COPY_INP_TMP.TupleFind("max_num_selectable_models");
                    if ((int)new HTuple(hv_Indices.TupleNotEqual(-1)).TupleAnd(new HTuple(hv_Indices.TupleNotEqual(
                        new HTuple()))) != 0)
                    {
                        if ((int)hv_GenParamValue_COPY_INP_TMP.TupleSelect(hv_Indices.TupleSelect(
                            0)).TupleIsNumber() != 0)
                        {
                            if ((int)new HTuple(hv_GenParamValue_COPY_INP_TMP.TupleSelect(
                                hv_Indices.TupleSelect(0)).TupleNumber().TupleInt().TupleLess(
                                1)) != 0)
                            {
                                //Wrong parameter value: Only integer values greater than 0 are allowed
                                throw new HalconException("Wrong value for parameter 'max_num_selectable_models' (must be an integer value greater than 0)");
                            }
                        }
                        else
                        {
                            //Wrong parameter value: Only integer values greater than 0 are allowed
                            throw new HalconException("Wrong value for parameter 'max_num_selectable_models' (must be an integer value greater than 0)");
                        }
                        hv_MaxNumModels = hv_GenParamValue_COPY_INP_TMP.TupleSelect(hv_Indices.TupleSelect(
                            0)).TupleNumber().TupleInt();
                        hv_GenParamName_COPY_INP_TMP = hv_GenParamName_COPY_INP_TMP.TupleRemove(
                            hv_Indices);
                        hv_GenParamValue_COPY_INP_TMP = hv_GenParamValue_COPY_INP_TMP.TupleRemove(
                            hv_Indices);
                    }
                    //
                    //Check the generic parameters for window_centered_rotation
                    //(Note that the default is set above to WindowCenteredRotation := 2)
                    hv_Indices = hv_GenParamName_COPY_INP_TMP.TupleFind("inspection_mode");
                    if ((int)new HTuple(hv_Indices.TupleNotEqual(-1)).TupleAnd(new HTuple(hv_Indices.TupleNotEqual(
                        new HTuple()))) != 0)
                    {
                        if ((int)new HTuple(hv_GenParamValue_COPY_INP_TMP.TupleSelect(hv_Indices.TupleSelect(
                            0)).TupleEqual("surface")) != 0)
                        {
                            hv_WindowCenteredRotation = 1;
                        }
                        else if ((int)new HTuple(hv_GenParamValue_COPY_INP_TMP.TupleSelect(
                            hv_Indices.TupleSelect(0)).TupleEqual("standard")) != 0)
                        {
                            hv_WindowCenteredRotation = 2;
                        }
                        else
                        {
                            //Wrong parameter value, use default value
                        }
                        hv_GenParamName_COPY_INP_TMP = hv_GenParamName_COPY_INP_TMP.TupleRemove(
                            hv_Indices);
                        hv_GenParamValue_COPY_INP_TMP = hv_GenParamValue_COPY_INP_TMP.TupleRemove(
                            hv_Indices);
                    }
                    //
                    //Check the generic parameters for disp_background
                    //(The former parameter name 'use_background' is still supported
                    // for compatibility reasons)
                    hv_DispBackground = "false";
                    if ((int)new HTuple(new HTuple(hv_GenParamName_COPY_INP_TMP.TupleLength()
                        ).TupleGreater(0)) != 0)
                    {
                        hv_Mask = hv_GenParamName_COPY_INP_TMP.TupleEqualElem("disp_background").TupleOr(
                            hv_GenParamName_COPY_INP_TMP.TupleEqualElem("use_background"));
                        hv_Indices = hv_Mask.TupleFind(1);
                    }
                    else
                    {
                        hv_Indices = -1;
                    }
                    if ((int)new HTuple(hv_Indices.TupleNotEqual(-1)).TupleAnd(new HTuple(hv_Indices.TupleNotEqual(
                        new HTuple()))) != 0)
                    {
                        hv_DispBackground = hv_GenParamValue_COPY_INP_TMP.TupleSelect(hv_Indices.TupleSelect(
                            0));
                        if ((int)new HTuple(hv_DispBackground.TupleNotEqual("true")).TupleAnd(
                            new HTuple(hv_DispBackground.TupleNotEqual("false"))) != 0)
                        {
                            //Wrong parameter value: Only 'true' and 'false' are allowed
                            throw new HalconException("Wrong value for parameter 'disp_background' (must be either 'true' or 'false')");
                        }
                        //Note the the background is handled explicitly in this procedure
                        //and therefore, the parameter is removed from the list of
                        //parameters and disp_background is always set to true (see below)
                        hv_GenParamName_COPY_INP_TMP = hv_GenParamName_COPY_INP_TMP.TupleRemove(
                            hv_Indices);
                        hv_GenParamValue_COPY_INP_TMP = hv_GenParamValue_COPY_INP_TMP.TupleRemove(
                            hv_Indices);
                    }
                    //
                    //Read and check the parameter Label for each object
                    if ((int)new HTuple(new HTuple(hv_Label_COPY_INP_TMP.TupleLength()).TupleEqual(
                        0)) != 0)
                    {
                        hv_Label_COPY_INP_TMP = 0;
                    }
                    else if ((int)new HTuple(new HTuple(hv_Label_COPY_INP_TMP.TupleLength()
                        ).TupleEqual(1)) != 0)
                    {
                        hv_Label_COPY_INP_TMP = HTuple.TupleGenConst(hv_NumModels, hv_Label_COPY_INP_TMP);
                    }
                    else
                    {
                        if ((int)new HTuple(new HTuple(hv_Label_COPY_INP_TMP.TupleLength()).TupleNotEqual(
                            hv_NumModels)) != 0)
                        {
                            //Error: Number of elements in Label does not match the
                            //number of object models

                        }
                    }
                    //
                    //Read and check the parameter PoseIn for each object
                    get_object_models_center(hv_ObjectModel3D, out hv_Center);
                    if ((int)new HTuple(new HTuple(hv_PoseIn_COPY_INP_TMP.TupleLength()).TupleEqual(
                        0)) != 0)
                    {
                        //If no pose was specified by the caller, automatically calculate
                        //a pose that is appropriate for the visualization.
                        //Set the initial model reference pose. The orientation is parallel
                        //to the object coordinate system, the position is at the center
                        //of gravity of all models.
                        HOperatorSet.CreatePose(-hv_Center.TupleSelect(0), -hv_Center.TupleSelect(
                            1), -hv_Center.TupleSelect(2), 0, 0, 0, "Rp+T", "gba", "point",
                            out hv_PoseIn_COPY_INP_TMP);
                        determine_optimum_pose_distance(hv_ObjectModel3D, hv_CamParam_COPY_INP_TMP,
                            0.9, hv_PoseIn_COPY_INP_TMP, out hv_PoseEstimated);
                        hv_Poses = new HTuple();
                        hv_HomMat3Ds = new HTuple();
                        hv_Sequence = HTuple.TupleGenSequence(0, hv_NumModels * 7 - 1, 1);
                        hv_Poses = hv_PoseEstimated.TupleSelect(hv_Sequence % 7);
                        ExpTmpLocalVar_gIsSinglePose = 1;
                        ExpSetGlobalVar_gIsSinglePose(ExpTmpLocalVar_gIsSinglePose);
                    }
                    else if ((int)new HTuple(new HTuple(hv_PoseIn_COPY_INP_TMP.TupleLength()
                        ).TupleEqual(7)) != 0)
                    {
                        hv_Poses = new HTuple();
                        hv_HomMat3Ds = new HTuple();
                        hv_Sequence = HTuple.TupleGenSequence(0, hv_NumModels * 7 - 1, 1);
                        hv_Poses = hv_PoseIn_COPY_INP_TMP.TupleSelect(hv_Sequence % 7);
                        ExpTmpLocalVar_gIsSinglePose = 1;
                        ExpSetGlobalVar_gIsSinglePose(ExpTmpLocalVar_gIsSinglePose);
                    }
                    else
                    {
                        if ((int)new HTuple(new HTuple(hv_PoseIn_COPY_INP_TMP.TupleLength()).TupleNotEqual(
                            new HTuple(hv_ObjectModel3D.TupleLength()) * 7)) != 0)
                        {
                            //Error: Wrong number of values of input control parameter 'PoseIn'

                        }
                        else
                        {
                            hv_Poses = hv_PoseIn_COPY_INP_TMP.Clone();
                        }
                        ExpTmpLocalVar_gIsSinglePose = 0;
                        ExpSetGlobalVar_gIsSinglePose(ExpTmpLocalVar_gIsSinglePose);
                    }

                    //
                    //Open (invisible) buffer window to avoid flickering
                    //open_window(...);
                    HOperatorSet.SetPart(hv_ExpDefaultWinHandle, 0, 0, hv_Height - 1, hv_Width - 1);
                    HOperatorSet.GetFont(hv_ExpDefaultWinHandle, out hv_Font);
                    try
                    {
                        HOperatorSet.SetFont(hv_ExpDefaultWinHandle, hv_Font);
                    }
                    // catch (Exception) 
                    catch (HalconException HDevExpDefaultException2)
                    {
                        HDevExpDefaultException2.ToHTuple(out hv_Exception);
                    }
                    //
                    // Is OpenGL available and should it be used?
                    ExpTmpLocalVar_gUsesOpenGL = "true";
                    ExpSetGlobalVar_gUsesOpenGL(ExpTmpLocalVar_gUsesOpenGL);
                    hv_Indices = hv_GenParamName_COPY_INP_TMP.TupleFind("opengl");
                    if ((int)new HTuple(hv_Indices.TupleNotEqual(-1)).TupleAnd(new HTuple(hv_Indices.TupleNotEqual(
                        new HTuple()))) != 0)
                    {
                        ExpTmpLocalVar_gUsesOpenGL = hv_GenParamValue_COPY_INP_TMP.TupleSelect(
                            hv_Indices.TupleSelect(0));
                        ExpSetGlobalVar_gUsesOpenGL(ExpTmpLocalVar_gUsesOpenGL);
                        hv_GenParamName_COPY_INP_TMP = hv_GenParamName_COPY_INP_TMP.TupleRemove(
                            hv_Indices);
                        hv_GenParamValue_COPY_INP_TMP = hv_GenParamValue_COPY_INP_TMP.TupleRemove(
                            hv_Indices);
                        if ((int)new HTuple(ExpGetGlobalVar_gUsesOpenGL().TupleNotEqual("true")).TupleAnd(
                            new HTuple(ExpGetGlobalVar_gUsesOpenGL().TupleNotEqual("false"))) != 0)
                        {
                            //Wrong parameter value: Only 'true' and 'false' are allowed
                            throw new HalconException("Wrong value for parameter 'opengl' (must be either 'true' or 'false')");
                        }
                    }
                    if ((int)new HTuple(ExpGetGlobalVar_gUsesOpenGL().TupleEqual("true")) != 0)
                    {
                        HOperatorSet.GetSystem("opengl_info", out hv_OpenGLInfo);
                        if ((int)new HTuple(hv_OpenGLInfo.TupleEqual("No OpenGL support included.")) != 0)
                        {
                            ExpTmpLocalVar_gUsesOpenGL = "false";
                            ExpSetGlobalVar_gUsesOpenGL(ExpTmpLocalVar_gUsesOpenGL);
                        }
                        else
                        {
                            HOperatorSet.GenObjectModel3dFromPoints(0, 0, 0, out hv_DummyObjectModel3D);
                            HOperatorSet.CreateScene3d(out hv_Scene3DTest);
                            HOperatorSet.AddScene3dCamera(hv_Scene3DTest, hv_CamParam_COPY_INP_TMP,
                                out hv_CameraIndexTest);
                            determine_optimum_pose_distance(hv_DummyObjectModel3D, hv_CamParam_COPY_INP_TMP,
                                0.9, new HTuple(0).TupleConcat(0).TupleConcat(0).TupleConcat(
                                0).TupleConcat(0).TupleConcat(0).TupleConcat(0), out hv_PoseTest);
                            HOperatorSet.AddScene3dInstance(hv_Scene3DTest, hv_DummyObjectModel3D,
                                hv_PoseTest, out hv_InstanceIndexTest);
                            try
                            {
                                HOperatorSet.DisplayScene3d(hv_ExpDefaultWinHandle, hv_Scene3DTest,
                                    hv_InstanceIndexTest);
                            }
                            // catch (Exception) 
                            catch (HalconException HDevExpDefaultException2)
                            {
                                HDevExpDefaultException2.ToHTuple(out hv_Exception);
                                ExpTmpLocalVar_gUsesOpenGL = "false";
                                ExpSetGlobalVar_gUsesOpenGL(ExpTmpLocalVar_gUsesOpenGL);
                            }
                            HOperatorSet.ClearScene3d(hv_Scene3DTest);
                            hv_Scene3DTest = new HTuple();
                            HOperatorSet.ClearObjectModel3d(hv_DummyObjectModel3D);
                        }
                    }
                    //
                    //Compute the trackball
                    hv_MinImageSize = hv_Width.TupleConcat(hv_Height).TupleMin();
                    hv_TrackballRadiusPixel = hv_TrackballSize * hv_MinImageSize / 2.0;
                    //
                    //Measure the text extents for the continue button in the
                    //graphics window
                    HOperatorSet.GetStringExtents(hv_ExpDefaultWinHandle, ExpGetGlobalVar_gTerminationButtonLabel() + "  ",
                        out hv_Ascent, out hv_Descent, out hv_TextWidth, out hv_TextHeight);
                    //
                    //Store background image
                    if ((int)new HTuple(hv_DispBackground.TupleEqual("false")) != 0)
                    {
                        HOperatorSet.ClearWindow(hv_ExpDefaultWinHandle);
                    }
                    ho_Image.Dispose();
                    HOperatorSet.DumpWindowImage(out ho_Image, hv_ExpDefaultWinHandle);
                    //Special treatment for color background images necessary
                    HOperatorSet.CountChannels(ho_Image, out hv_NumChannels);
                    hv_ColorImage = new HTuple(hv_NumChannels.TupleEqual(3));
                    //
                    HOperatorSet.CreateScene3d(out hv_Scene3D);
                    HOperatorSet.AddScene3dCamera(hv_Scene3D, hv_CamParam_COPY_INP_TMP, out hv_CameraIndex);
                    HOperatorSet.AddScene3dInstance(hv_Scene3D, hv_ObjectModel3D, hv_Poses, out hv_AllInstances);
                    //Always set 'disp_background' to true,  because it is handled explicitly
                    //in this procedure (see above)
                    HOperatorSet.SetScene3dParam(hv_Scene3D, "disp_background", "true");
                    //Check if we have to set light specific parameters
                    hv_SetLight = new HTuple(hv_GenParamName_COPY_INP_TMP.TupleRegexpTest("light_"));
                    if ((int)hv_SetLight != 0)
                    {
                        //set position of light source
                        hv_Indices = hv_GenParamName_COPY_INP_TMP.TupleFind("light_position");
                        if ((int)new HTuple(hv_Indices.TupleNotEqual(-1)).TupleAnd(new HTuple(hv_Indices.TupleNotEqual(
                            new HTuple()))) != 0)
                        {
                            //If multiple light positions are given, use the last one
                            hv_LightParam = hv_GenParamValue_COPY_INP_TMP.TupleSelect(hv_Indices.TupleSelect(
                                new HTuple(hv_Indices.TupleLength()) - 1)).TupleSplit(new HTuple(", ")).TupleNumber()
                                ;
                            if ((int)new HTuple(new HTuple(hv_LightParam.TupleLength()).TupleNotEqual(
                                4)) != 0)
                            {
                                throw new HalconException("light_position must be given as a string that contains four space separated floating point numbers");
                            }
                            hv_LightPosition = hv_LightParam.TupleSelectRange(0, 2);
                            hv_LightKind = "point_light";
                            if ((int)new HTuple(hv_LightParam.TupleSelect(3).TupleEqual(0)) != 0)
                            {
                                hv_LightKind = "directional_light";
                            }
                            //Currently, only one light source is supported
                            HOperatorSet.RemoveScene3dLight(hv_Scene3D, 0);
                            HOperatorSet.AddScene3dLight(hv_Scene3D, hv_LightPosition, hv_LightKind,
                                out hv_LightIndex);
                            HOperatorSet.TupleRemove(hv_GenParamName_COPY_INP_TMP, hv_Indices, out hv_GenParamName_COPY_INP_TMP);
                            HOperatorSet.TupleRemove(hv_GenParamValue_COPY_INP_TMP, hv_Indices, out hv_GenParamValue_COPY_INP_TMP);
                        }
                        //set ambient part of light source
                        hv_Indices = hv_GenParamName_COPY_INP_TMP.TupleFind("light_ambient");
                        if ((int)new HTuple(hv_Indices.TupleNotEqual(-1)).TupleAnd(new HTuple(hv_Indices.TupleNotEqual(
                            new HTuple()))) != 0)
                        {
                            //If the ambient part is set multiple times, use the last setting
                            hv_LightParam = hv_GenParamValue_COPY_INP_TMP.TupleSelect(hv_Indices.TupleSelect(
                                new HTuple(hv_Indices.TupleLength()) - 1)).TupleSplit(new HTuple(", ")).TupleNumber()
                                ;
                            if ((int)new HTuple(new HTuple(hv_LightParam.TupleLength()).TupleLess(
                                3)) != 0)
                            {
                                throw new HalconException("light_ambient must be given as a string that contains three space separated floating point numbers");
                            }
                            HOperatorSet.SetScene3dLightParam(hv_Scene3D, 0, "ambient", hv_LightParam.TupleSelectRange(
                                0, 2));
                            HOperatorSet.TupleRemove(hv_GenParamName_COPY_INP_TMP, hv_Indices, out hv_GenParamName_COPY_INP_TMP);
                            HOperatorSet.TupleRemove(hv_GenParamValue_COPY_INP_TMP, hv_Indices, out hv_GenParamValue_COPY_INP_TMP);
                        }
                        //Set diffuse part of light source
                        hv_Indices = hv_GenParamName_COPY_INP_TMP.TupleFind("light_diffuse");
                        if ((int)new HTuple(hv_Indices.TupleNotEqual(-1)).TupleAnd(new HTuple(hv_Indices.TupleNotEqual(
                            new HTuple()))) != 0)
                        {
                            //If the diffuse part is set multiple times, use the last setting
                            hv_LightParam = hv_GenParamValue_COPY_INP_TMP.TupleSelect(hv_Indices.TupleSelect(
                                new HTuple(hv_Indices.TupleLength()) - 1)).TupleSplit(new HTuple(", ")).TupleNumber()
                                ;
                            if ((int)new HTuple(new HTuple(hv_LightParam.TupleLength()).TupleLess(
                                3)) != 0)
                            {
                                throw new HalconException("light_diffuse must be given as a string that contains three space separated floating point numbers");
                            }
                            HOperatorSet.SetScene3dLightParam(hv_Scene3D, 0, "diffuse", hv_LightParam.TupleSelectRange(
                                0, 2));
                            HOperatorSet.TupleRemove(hv_GenParamName_COPY_INP_TMP, hv_Indices, out hv_GenParamName_COPY_INP_TMP);
                            HOperatorSet.TupleRemove(hv_GenParamValue_COPY_INP_TMP, hv_Indices, out hv_GenParamValue_COPY_INP_TMP);
                        }
                    }
                    //
                    //Handle persistence parameters separately because persistence will
                    //only be activated immediately before leaving the visualization
                    //procedure
                    hv_PersistenceParamName = new HTuple();
                    hv_PersistenceParamValue = new HTuple();
                    //Set position of light source
                    hv_Indices = hv_GenParamName_COPY_INP_TMP.TupleFind("object_index_persistence");
                    if ((int)new HTuple(hv_Indices.TupleNotEqual(-1)).TupleAnd(new HTuple(hv_Indices.TupleNotEqual(
                        new HTuple()))) != 0)
                    {
                        if ((int)new HTuple(hv_GenParamValue_COPY_INP_TMP.TupleSelect(hv_Indices.TupleSelect(
                            new HTuple(hv_Indices.TupleLength()) - 1)).TupleEqual("true")) != 0)
                        {
                            hv_PersistenceParamName = hv_PersistenceParamName.TupleConcat("object_index_persistence");
                            hv_PersistenceParamValue = hv_PersistenceParamValue.TupleConcat("true");
                        }
                        else if ((int)new HTuple(hv_GenParamValue_COPY_INP_TMP.TupleSelect(
                            hv_Indices.TupleSelect(new HTuple(hv_Indices.TupleLength()) - 1)).TupleEqual(
                            "false")) != 0)
                        {
                        }
                        else
                        {
                            throw new HalconException("Wrong value for parameter 'object_index_persistence' (must be either 'true' or 'false')");
                        }
                        HOperatorSet.TupleRemove(hv_GenParamName_COPY_INP_TMP, hv_Indices, out hv_GenParamName_COPY_INP_TMP);
                        HOperatorSet.TupleRemove(hv_GenParamValue_COPY_INP_TMP, hv_Indices, out hv_GenParamValue_COPY_INP_TMP);
                    }
                    hv_Indices = hv_GenParamName_COPY_INP_TMP.TupleFind("depth_persistence");
                    if ((int)new HTuple(hv_Indices.TupleNotEqual(-1)).TupleAnd(new HTuple(hv_Indices.TupleNotEqual(
                        new HTuple()))) != 0)
                    {
                        if ((int)new HTuple(hv_GenParamValue_COPY_INP_TMP.TupleSelect(hv_Indices.TupleSelect(
                            new HTuple(hv_Indices.TupleLength()) - 1)).TupleEqual("true")) != 0)
                        {
                            hv_PersistenceParamName = hv_PersistenceParamName.TupleConcat("depth_persistence");
                            hv_PersistenceParamValue = hv_PersistenceParamValue.TupleConcat("true");
                        }
                        else if ((int)new HTuple(hv_GenParamValue_COPY_INP_TMP.TupleSelect(
                            hv_Indices.TupleSelect(new HTuple(hv_Indices.TupleLength()) - 1)).TupleEqual(
                            "false")) != 0)
                        {
                        }
                        else
                        {
                            throw new HalconException("Wrong value for parameter 'depth_persistence' (must be either 'true' or 'false')");
                        }
                        HOperatorSet.TupleRemove(hv_GenParamName_COPY_INP_TMP, hv_Indices, out hv_GenParamName_COPY_INP_TMP);
                        HOperatorSet.TupleRemove(hv_GenParamValue_COPY_INP_TMP, hv_Indices, out hv_GenParamValue_COPY_INP_TMP);
                    }
                    //
                    //Parse the generic parameters
                    //- First, all parameters that are understood by set_scene_3d_instance_param
                    hv_AlphaOrig = HTuple.TupleGenConst(hv_NumModels, 1);
                    for (hv_I = 0; (int)hv_I <= (int)(new HTuple(hv_GenParamName_COPY_INP_TMP.TupleLength()
                        ) - 1); hv_I = (int)hv_I + 1)

                    {
                        Application.DoEvents();
                        hv_ParamName = hv_GenParamName_COPY_INP_TMP.TupleSelect(hv_I);
                        hv_ParamValue = hv_GenParamValue_COPY_INP_TMP.TupleSelect(hv_I);
                        //Check if this parameter is understood by set_scene_3d_param
                        if ((int)new HTuple(hv_ParamName.TupleEqual("alpha")) != 0)
                        {
                            hv_AlphaOrig = HTuple.TupleGenConst(hv_NumModels, hv_ParamValue);
                        }
                        try
                        {
                            HOperatorSet.SetScene3dParam(hv_Scene3D, hv_ParamName, hv_ParamValue);
                            continue;
                        }
                        // catch (Exception) 
                        catch (HalconException HDevExpDefaultException2)
                        {
                            HDevExpDefaultException2.ToHTuple(out hv_Exception);
                            if ((int)new HTuple(hv_Exception.TupleSelect(0).TupleEqual(1203)).TupleOr(
                                new HTuple(hv_Exception.TupleSelect(0).TupleEqual(1303))) != 0)
                            {
                                throw new HalconException("Wrong type or value for parameter " + hv_ParamName + ": " + hv_ParamValue);
                            }
                        }
                        //Check if it is a parameter that is valid for only one instance
                        //and therefore can be set only with set_scene_3d_instance_param
                        hv_ParamNameTrunk = hv_ParamName.TupleRegexpReplace("_\\d+$", "");
                        if ((int)new HTuple(hv_ParamName.TupleEqual(hv_ParamNameTrunk)) != 0)
                        {
                            hv_Instance = HTuple.TupleGenSequence(0, hv_NumModels - 1, 1);
                        }
                        else
                        {
                            hv_Instance = hv_ParamName.TupleRegexpReplace("^" + hv_ParamNameTrunk + "_(\\d+)$",
                                "$1").TupleNumber();
                            if ((int)new HTuple(hv_Instance.TupleLess(0)).TupleOr(new HTuple(hv_Instance.TupleGreater(
                                hv_NumModels - 1))) != 0)
                            {
                                throw new HalconException("Parameter " + hv_ParamName + " refers to a non existing 3D object model");
                            }
                        }
                        try
                        {
                            HOperatorSet.SetScene3dInstanceParam(hv_Scene3D, hv_Instance, hv_ParamNameTrunk,
                                hv_ParamValue);
                        }
                        // catch (Exception) 
                        catch (HalconException HDevExpDefaultException2)
                        {
                            HDevExpDefaultException2.ToHTuple(out hv_Exception);
                            if ((int)new HTuple(hv_Exception.TupleSelect(0).TupleEqual(1204)).TupleOr(
                                new HTuple(hv_Exception.TupleSelect(0).TupleEqual(1304))) != 0)
                            {
                                throw new HalconException("Wrong type or value for parameter " + hv_ParamName + ": " + hv_ParamValue);
                            }
                            else if ((int)new HTuple(hv_Exception.TupleSelect(0).TupleEqual(
                                1203)).TupleOr(new HTuple(hv_Exception.TupleSelect(0).TupleEqual(
                                1303))) != 0)
                            {
                                throw new HalconException("Wrong parameter name " + hv_ParamName);
                            }
                            else
                            {
                                throw new HalconException(hv_Exception);
                            }
                        }
                        if ((int)new HTuple(hv_ParamNameTrunk.TupleEqual("alpha")) != 0)
                        {
                            if (hv_AlphaOrig == null)
                                hv_AlphaOrig = new HTuple();
                            hv_AlphaOrig[hv_Instance] = hv_ParamValue;
                        }
                    }
                    //
                    //Start the visualization loop
                    HOperatorSet.PoseToHomMat3d(hv_Poses.TupleSelectRange(0, 6), out hv_HomMat3D);
                    HOperatorSet.AffineTransPoint3d(hv_HomMat3D, hv_Center.TupleSelect(0), hv_Center.TupleSelect(
                        1), hv_Center.TupleSelect(2), out hv_Qx, out hv_Qy, out hv_Qz);
                    hv_TBCenter = new HTuple();
                    hv_TBCenter = hv_TBCenter.TupleConcat(hv_Qx);
                    hv_TBCenter = hv_TBCenter.TupleConcat(hv_Qy);
                    hv_TBCenter = hv_TBCenter.TupleConcat(hv_Qz);
                    hv_TBSize = (0.5 + 0.5 * hv_SelectedObject.TupleSum() / hv_NumModels) * hv_TrackballRadiusPixel;
                    hv_ButtonHold = 0;


                    while (Exi)
                    {
                        Application.DoEvents();
                        if (ExitLoop)
                        {
                            try
                            {
                                analyze_graph_event(ho_Image, hv_MouseMapping, hv_GraphButton, hv_GraphButtonRow,
                                                                                      hv_GraphButtonColumn, hv_WindowHandle, hv_WindowHandleBuffer, hv_VirtualTrackball,
                                                                                      hv_TrackballSize, hv_SelectedObject, hv_Scene3D, hv_AlphaOrig, hv_ObjectModel3D,
                                                                                      hv_CamParam_COPY_INP_TMP, hv_Label_COPY_INP_TMP, hv_Title, hv_Information,
                                                                                      hv_GenParamName_COPY_INP_TMP, hv_GenParamValue_COPY_INP_TMP, hv_Poses,
                                                                                      hv_ButtonHold, hv_TBCenter, hv_TBSize, hv_WindowCenteredRotation,
                                                                                      hv_MaxNumModels, out hv_Poses, out hv_SelectedObject, out hv_ButtonHold,
                                                                                      out hv_WindowCenteredRotation);

                            }
                            catch (Exception)
                            {

                                break;
                            }
                            return;

                        }
                        Application.DoEvents();

                        if (ExitLoop == true)//手动退出
                        {
                            hv_ButtonReleased = 1;

                            hv_Exit = 1;


                            return;
                        }
                        hv_VisualizeTB = new HTuple(hv_SelectedObject.TupleMax().TupleNotEqual(
                            0));
                        hv_MaxIndex = new HTuple(hv_ObjectModel3D.TupleLength()).TupleConcat(
                            hv_MaxNumModels).TupleMin() - 1;
                        //Set trackball fixed in the center of the window
                        hv_TrackballCenterRow = hv_Height / 2;
                        hv_TrackballCenterCol = hv_Width / 2;
                        if ((int)new HTuple(hv_WindowCenteredRotation.TupleEqual(1)) != 0)
                        {
                            try
                            {
                                get_trackball_center_fixed(hv_SelectedObject.TupleSelectRange(0, hv_MaxIndex),
                                    hv_TrackballCenterRow, hv_TrackballCenterCol, hv_TrackballRadiusPixel,
                                    hv_Scene3D, hv_ObjectModel3D.TupleSelectRange(0, hv_MaxIndex), hv_Poses.TupleSelectRange(
                                    0, (hv_MaxIndex + 1) * 7 - 1), hv_WindowHandleBuffer, hv_CamParam_COPY_INP_TMP,
                                    hv_GenParamName_COPY_INP_TMP, hv_GenParamValue_COPY_INP_TMP, out hv_TBCenter,
                                    out hv_TBSize);
                            }
                            // catch (Exception) 
                            catch (HalconException HDevExpDefaultException2)
                            {
                                HDevExpDefaultException2.ToHTuple(out hv_Exception);
                                disp_message(hv_ExpDefaultWinHandle, "Surface inspection mode is not available.",
                                    "image", 5, 20, "red", "true");
                                hv_WindowCenteredRotation = 2;
                                get_trackball_center(hv_SelectedObject.TupleSelectRange(0, hv_MaxIndex),
                                    hv_TrackballRadiusPixel, hv_ObjectModel3D.TupleSelectRange(0, hv_MaxIndex),
                                    hv_Poses.TupleSelectRange(0, (hv_MaxIndex + 1) * 7 - 1), out hv_TBCenter,
                                    out hv_TBSize);
                                HOperatorSet.WaitSeconds(1);
                            }
                        }
                        else
                        {
                            get_trackball_center(hv_SelectedObject.TupleSelectRange(0, hv_MaxIndex),
                                hv_TrackballRadiusPixel, hv_ObjectModel3D.TupleSelectRange(0, hv_MaxIndex),
                                hv_Poses.TupleSelectRange(0, (hv_MaxIndex + 1) * 7 - 1), out hv_TBCenter,
                                out hv_TBSize);
                        }
                        dump_image_output(ho_Image, hv_ExpDefaultWinHandle, hv_Scene3D, hv_AlphaOrig,
                            hv_ObjectModel3D, hv_GenParamName_COPY_INP_TMP, hv_GenParamValue_COPY_INP_TMP,
                            hv_CamParam_COPY_INP_TMP, hv_Poses, hv_ColorImage, hv_Title, hv_Information,
                            hv_Label_COPY_INP_TMP, hv_VisualizeTB, "true", hv_TrackballCenterRow,
                            hv_TrackballCenterCol, hv_TBSize, hv_SelectedObject, hv_WindowCenteredRotation,
                            hv_TBCenter);
                        ho_ImageDump.Dispose();
                        HOperatorSet.DumpWindowImage(out ho_ImageDump, hv_ExpDefaultWinHandle);
                        //dev_set_window(...);
                        HOperatorSet.DispObj(ho_ImageDump, hv_ExpDefaultWinHandle);
                        //
                        //Check for mouse events
                        hv_GraphEvent = 0;
                        hv_Exit = 0;

                        while (Exi)
                        {
                            Application.DoEvents();
                            if (ExitLoop == true)//手动退出
                            {
                                hv_ButtonReleased = 1;
                                hv_Exit = 1;
                                return;
                            }
                            //
                            //Check graphic event
                            try
                            {
                                HOperatorSet.GetMpositionSubPix(hv_ExpDefaultWinHandle, out hv_GraphButtonRow,
                                    out hv_GraphButtonColumn, out hv_GraphButton);
                                if ((int)new HTuple(hv_GraphButton.TupleNotEqual(0)) != 0)
                                {
                                    if ((int)new HTuple(new HTuple(new HTuple(hv_GraphButtonRow.TupleGreater(
                                        hv_Height - hv_TextHeight - 25)).TupleAnd(new HTuple(hv_GraphButtonRow.TupleLess(
                                        hv_Height)))).TupleAnd(new HTuple(hv_GraphButtonColumn.TupleGreater(
                                        hv_Width - hv_TextWidth - 15)))).TupleAnd(new HTuple(hv_GraphButtonColumn.TupleLess(
                                        hv_Width))) != 0)
                                    {
                                        //Wait until the continue button has been released
                                        if ((int)new HTuple(hv_WaitForButtonRelease.TupleEqual("true")) != 0)
                                        {
                                            Application.DoEvents();

                                            if (ExitLoop == true)//手动退出
                                            {
                                                hv_ButtonReleased = 1;
                                                hv_Exit = 1;
                                                return;
                                            }
                                        }

                                    }
                                    hv_GraphEvent = 1;
                                    break;
                                }
                                else
                                {
                                    hv_ButtonHold = 0;
                                }
                            }
                            // catch (Exception) 
                            catch (HalconException HDevExpDefaultException2)
                            {
                                HDevExpDefaultException2.ToHTuple(out hv_Exception);
                                //Keep waiting
                            }


                        }



                        if ((int)hv_GraphEvent != 0)
                        {

                            analyze_graph_event(ho_Image, hv_MouseMapping, hv_GraphButton, hv_GraphButtonRow,
                                hv_GraphButtonColumn, hv_WindowHandle, hv_WindowHandleBuffer, hv_VirtualTrackball,
                                hv_TrackballSize, hv_SelectedObject, hv_Scene3D, hv_AlphaOrig, hv_ObjectModel3D,
                                hv_CamParam_COPY_INP_TMP, hv_Label_COPY_INP_TMP, hv_Title, hv_Information,
                                hv_GenParamName_COPY_INP_TMP, hv_GenParamValue_COPY_INP_TMP, hv_Poses,
                                hv_ButtonHold, hv_TBCenter, hv_TBSize, hv_WindowCenteredRotation,
                                hv_MaxNumModels, out hv_Poses, out hv_SelectedObject, out hv_ButtonHold,
                                out hv_WindowCenteredRotation);

                        }



                        if ((int)hv_Exit != 0)
                        {
                            break;
                        }

                    }


                    if ((int)new HTuple(new HTuple(hv_PersistenceParamName.TupleLength()).TupleGreater(
                        0)) != 0)
                    {
                        try
                        {
                            HOperatorSet.DispObjectModel3d(hv_ExpDefaultWinHandle, hv_ObjectModel3D,
                                hv_CamParam_COPY_INP_TMP, hv_Poses, new HTuple("disp_background").TupleConcat(
                                "alpha").TupleConcat(hv_PersistenceParamName), new HTuple("true").TupleConcat(
                                0.0).TupleConcat(hv_PersistenceParamValue));
                        }
                        // catch (Exception) 
                        catch (HalconException HDevExpDefaultException2)
                        {
                            HDevExpDefaultException2.ToHTuple(out hv_Exception);
                        }
                    }
                    //
                    //Compute the output pose
                    if ((int)ExpGetGlobalVar_gIsSinglePose() != 0)
                    {
                        hv_PoseOut = hv_Poses.TupleSelectRange(0, 6);
                    }
                    else
                    {
                        hv_PoseOut = hv_Poses.Clone();
                    }
                    //
                    //Clean up
                    HOperatorSet.SetSystem("clip_region", hv_ClipRegion);

                    dump_image_output(ho_Image, hv_ExpDefaultWinHandle, hv_Scene3D, hv_AlphaOrig,
                        hv_ObjectModel3D, hv_GenParamName_COPY_INP_TMP, hv_GenParamValue_COPY_INP_TMP,
                        hv_CamParam_COPY_INP_TMP, hv_Poses, hv_ColorImage, hv_Title, new HTuple(),
                        hv_Label_COPY_INP_TMP, 0, "false", hv_TrackballCenterRow, hv_TrackballCenterCol,
                        hv_TBSize, hv_SelectedObject, hv_WindowCenteredRotation, hv_TBCenter);
                    ho_ImageDump.Dispose();
                    HOperatorSet.DumpWindowImage(out ho_ImageDump, hv_ExpDefaultWinHandle);
                    //dev_set_window(...);
                    HOperatorSet.DispObj(ho_ImageDump, hv_ExpDefaultWinHandle);
                    //close_window(...);
                    HOperatorSet.SetPart(hv_ExpDefaultWinHandle, hv_WPRow1, hv_WPColumn1, hv_WPRow2,
                        hv_WPColumn2);
                    HOperatorSet.ClearScene3d(hv_Scene3D);
                    hv_Scene3D = new HTuple();
                }
                // catch (Exception) 
                catch (HalconException HDevExpDefaultException1)
                {
                    HDevExpDefaultException1.ToHTuple(out hv_Exception);
                    try
                    {
                        if ((int)new HTuple(new HTuple(0).TupleLess(new HTuple(hv_Scene3DTest.TupleLength()
                            ))) != 0)
                        {
                            HOperatorSet.ClearScene3d(hv_Scene3DTest);
                            hv_Scene3DTest = new HTuple();
                        }
                        if ((int)new HTuple(new HTuple(0).TupleLess(new HTuple(hv_Scene3D.TupleLength()
                            ))) != 0)
                        {
                            HOperatorSet.ClearScene3d(hv_Scene3D);
                            hv_Scene3D = new HTuple();
                        }
                        if ((int)new HTuple(new HTuple(0).TupleLess(new HTuple(hv_WindowHandleBuffer.TupleLength()
                            ))) != 0)
                        {
                            //close_window(...);
                            hv_WindowHandleBuffer = new HTuple();
                        }
                    }
                    // catch (e) 
                    catch (HalconException HDevExpDefaultException2)
                    {
                        HDevExpDefaultException2.ToHTuple(out hv_e);

                    }

                    throw new HalconException(hv_Exception);
                }

                return;
            }
            catch (HalconException)
            {

                return;
            }
        }


        #region 显示3D模型
        public void Show3D(HTuple model, HTuple pose, HTuple hv_name, HTuple hv_value, out HTuple poseOut)
        {
            ExitLoop = false;
            HOperatorSet.ClearWindow(hv_ExpDefaultWinHandle);
            visualize_object_model_3d(hv_ExpDefaultWinHandle, model, new HTuple(),
                pose, hv_name, hv_value, new HTuple(), new HTuple(), new HTuple(), out poseOut);
        }
        public void Show3D(HTuple model, HTuple hv_name, HTuple hv_value)
        {
            ExitLoop = false;
            HOperatorSet.ClearWindow(hv_ExpDefaultWinHandle);
            visualize_object_model_3d(hv_ExpDefaultWinHandle, model, new HTuple(),
                new HTuple(), hv_name, hv_value, new HTuple(), new HTuple(), new HTuple(), out _);
        }

        #endregion

    }
}
