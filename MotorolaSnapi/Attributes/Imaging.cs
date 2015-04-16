﻿using System;
using CoreScanner;
using Motorola.Snapi.Constants.AttributeNumbers;
using Motorola.Snapi.Constants.Enums;

namespace Motorola.Snapi.Attributes
{
    /// <summary>
    /// Provides properties for accessing and modifying scanner imaging attributes.
    /// </summary>
    public class Imaging : MotorolaAttributeSet
    {
        /// <summary>
        /// Initializes a new Imaging object
        /// </summary>
        /// <param name="scannerId">ID number of the scanner to get/set data from.</param>
        /// <param name="scannerDriver">CCoreScanner instance</param>
        internal Imaging(int scannerId, CCoreScanner scannerDriver) : base(scannerId, scannerDriver) {}

        /// <summary>
        /// <para>Driver Attribute Name: CropTop</para>
        /// <para>Description: This parameter sets the value at which the image is cropped from the top.</para>
        /// <para>Values: 0 to 1023</para>
        /// </summary>
        public ushort CropTop
        {
            get
            {
                return Convert.ToUInt16(GetAttribute(ImagingAttribute.CropTop)
                                            .Value);
            }
            set
            {
                SetAttribute(new ScannerAttribute{Id = ImagingAttribute.CropTop, DataType = DataType.UShort, Value = value});
            }
        }

        /// <summary>
        /// <para>Driver Attribute Name: CropLeft</para>
        /// <para>Description: This parameter sets the value at which the image is cropped from the left.</para>
        /// <para>Values: 0 to 1279</para>
        /// </summary>
        public ushort CropLeft
        {
            get
            {
                return Convert.ToUInt16(GetAttribute(ImagingAttribute.CropLeft)
                                            .Value);
            }
            set
            {
                SetAttribute(new ScannerAttribute { Id = ImagingAttribute.CropLeft, DataType = DataType.UShort, Value = value });
            }
        }

        /// <summary>
        /// <para>Driver Attribute Name: CropRight</para>
        /// <para>Description: This parameter sets the value at which the image is cropped from the right.</para>
        /// <para>Values: 0 to 1279</para>
        /// </summary>
        public ushort CropRight
        {
            get
            {
                return Convert.ToUInt16(GetAttribute(ImagingAttribute.CropRight)
                                            .Value);
            }
            set
            {
                SetAttribute(new ScannerAttribute { Id = ImagingAttribute.CropRight, DataType = DataType.UShort, Value = value });
            }
        }


        /// <summary>
        /// <para>Driver Attribute Name: CropBottom</para>
        /// <para>Description: This parameter sets the value at which the image is cropped from the bottom.</para>
        /// <para>Values: 0 to 1023</para>
        /// </summary>
        public ushort CropBottom
        {
            get
            {
                return Convert.ToUInt16(GetAttribute(ImagingAttribute.CropBottom)
                                            .Value);
            }
            set
            {
                SetAttribute(new ScannerAttribute { Id = ImagingAttribute.CropBottom, DataType = DataType.UShort, Value = value });
            }
        }

        /// <summary>
        /// <para>Driver Attribute Name: JPEGFileSizeWord</para>
        /// <para>Description: This parameter sets the size of the JPEG image in multiples of 1K.</para>
        /// <para>Values: 5 to 600</para>
        /// </summary>
        public ushort JPEGFileSize
        {
            get
            {
                return Convert.ToUInt16(GetAttribute(ImagingAttribute.JPEGFileSizeWord)
                                            .Value);
            }
            set
            {
                SetAttribute(new ScannerAttribute { Id = ImagingAttribute.JPEGFileSizeWord, DataType = DataType.UShort, Value = value });
            }
        }

        /// <summary>
        /// <para>Driver Attribute Name: Exposure</para>
        /// <para>Description: Sets the time of exposure.</para>
        /// <para>Values: 5 to 5000</para>
        /// </summary>
        public ushort Exposure
        {
            get
            {
                return Convert.ToUInt16(GetAttribute(ImagingAttribute.Exposure)
                                            .Value);
            }
            set
            {
                SetAttribute(new ScannerAttribute { Id = ImagingAttribute.Exposure, DataType = DataType.UShort, Value = value });
            }
        }

        /// <summary>
        /// <para>Driver Attribute Name: SnapshotByMotion</para>
        /// <para>Description: When enabled, once an object in the field of view remains stationary, an
        /// image will be taken and transmitted to the host. This applies to Snapshot mode only.</para>
        /// <para>Values: 5 to 5000</para>
        /// </summary>
        public bool SnapshotByMotionEnabled
        {
            get
            {
                return (bool)GetAttribute(ImagingAttribute.SnapshotByMotion)
                                 .Value;
            }
            set
            {
                SetAttribute(new ScannerAttribute { Id = ImagingAttribute.SnapshotByMotion, DataType = DataType.Bool, Value = value });
            }
        }

        /// <summary>
        /// <para>Driver Attribute Name: ContinuousSnapshot</para>
        /// <para>Description: Set to true to stay in Snapshot mode, and false to return to normal
        /// decode mode after image capture. This only applies in Presentation Snapshot by Motion mode.</para>
        /// <para>Values: true(On) false(Off)</para>
        /// </summary>
        public bool ContinuousSnapshotEnabled
        {
            get
            {
                return (bool)GetAttribute(ImagingAttribute.ContinuousSnapshot)
                                 .Value;
            }
            set
            {
                SetAttribute(new ScannerAttribute { Id = ImagingAttribute.ContinuousSnapshot, DataType = DataType.Bool, Value = value });
            }
        }

        /// <summary>
        /// <para>Driver Attribute Name: ImageEdgeSharpen</para>
        /// <para>Description: Sharpen image edges.</para>
        /// <para>Values: 0(Off) to 100(High)</para>
        /// </summary>
        public ushort ImageEdgeSharpen
        {
            get
            {
                return Convert.ToUInt16(GetAttribute(ImagingAttribute.ImageEdgeSharpen)
                                            .Value);
            }
            set
            {
                SetAttribute(new ScannerAttribute { Id = ImagingAttribute.ContinuousSnapshot, DataType = DataType.Byte, Value = value });
            }
        }

        /// <summary>
        /// <para>Driver Attribute Name: ImageRotation</para>
        /// <para>Description: Rotate images by the ammount of this value.</para>
        /// <para>Values:</para>
        /// <para>0 – 0 degrees</para>
        /// <para>1 – 90 degrees</para>
        /// <para>2 – 180 degrees</para>
        /// <para>3 – 270 degrees</para>
        /// </summary>
        public ImageRotation ImageRotation
        {
            get
            {
                return (ImageRotation)GetAttribute(ImagingAttribute.ImageRotation)
                                   .Value;
            }
            set
            {
                SetAttribute(new ScannerAttribute{ Id = ImagingAttribute.ImageRotation, DataType = DataType.Byte, Value = (byte)value });
            }
        }

        /// <summary>
        /// <para>Driver Attribute Name: ContrastEnhancement</para>
        /// <para>Description: Enhances the image contrast.</para>
        /// <para>Values: false (Disable), true (Enable)</para>
        /// </summary>
        public bool ContrastEnhancement
        {
            get
            {
                return (Convert.ToUInt16(GetAttribute(ImagingAttribute.ContrastEnhancement)
                                   .Value) == 1);
            }
            set
            {
                string v = value ? "1" : "0";
                SetAttribute(new ScannerAttribute { Id = ImagingAttribute.ContrastEnhancement, DataType = DataType.Byte, Value = v });
            }
        }

        /// <summary>
        /// <para>Driver Attribute Name: VideoSubsample</para>
        /// <para>Description: Sets the image resolution. Image size will be changed if you manipulate this parameter.</para>
        /// <para>Values: 0 to 3</para>
        /// </summary>
        public ushort ImageResolution
        {
            get
            {
                return Convert.ToUInt16(GetAttribute(ImagingAttribute.VideoSubsample)
                                            .Value);
            }
            set
            {
                SetAttribute(new ScannerAttribute { Id = ImagingAttribute.VideoSubsample, DataType = DataType.Byte, Value = value });
            }
        }

        /// <summary>
        /// <para>Driver Attribute Name: AimBrightness</para>
        /// <para>Description: Sets the brightness of the aim patterns by altering the aim duration.</para>
        /// <para>Values: 0 to 255 in .5ms increments</para>
        /// </summary>
        public ushort AimBrightness
        {
            get
            {
                return Convert.ToUInt16(GetAttribute(ImagingAttribute.AimBrightness)
                                            .Value);
            }
            set
            {
                SetAttribute(new ScannerAttribute { Id = ImagingAttribute.AimBrightness, DataType = DataType.Byte, Value = value });
            }
        }

        /// <summary>
        /// <para>Driver Attribute Name: IlluminationBrightness</para>
        /// <para>Description: Sets the brightness of the illumination.</para>
        /// <para>Values: 0 (weakest) to 10 (strongest)</para>
        /// </summary>
        public ushort IlluminationBrightness
        {
            get
            {
                return Convert.ToUInt16(GetAttribute(ImagingAttribute.IlluminationBrightness)
                                            .Value);
            }
            set
            {
                SetAttribute(new ScannerAttribute { Id = ImagingAttribute.IlluminationBrightness, DataType = DataType.Byte, Value = value });
            }
        }
    }
}
