using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FileFinderExample
{
    public class DriveInfoItem
    {
        public string DriveName { get; set; }
        public string DriveVolumeLabel { get; set; }
        public string DriveFormat { get; set; }
        public string DriveTypeString { get; set; }
        public string TotalFreeSpaceGb { get; set; }
        public long TotalSizeGb { get; set; }
        public long AvailableFreeSpaceGb { get; set; }

        public DriveInfoItem(DriveInfo driveInfo)
        {
            if (driveInfo == null)
            {
                throw new ArgumentNullException("driveInfo", "Ощибка: парамтер не может быть null!");
            }
            DriveName = driveInfo.Name;
            DriveVolumeLabel = driveInfo.VolumeLabel;
            DriveFormat = driveInfo.DriveFormat;

            DriveTypeString = GetDriveTypeAsString(driveInfo.DriveType);
            TotalFreeSpaceGb = GetSizeInGigabytesString(driveInfo.TotalFreeSpace);
            AvailableFreeSpaceGb = GetSizeInGigabytes(driveInfo.AvailableFreeSpace);
        }
        private string GetSizeInGigabytesString(long size)
        {
            return $"{GetSizeInGigabytes(size)} GB";
        }

        private long GetSizeInGigabytes(long size)
        {
            return size / 1_073_741_8224;
        }

        private string GetVolumeSizeString()
        {
            return string.Format("Объём {0}Гб, Всего свободно {1}, Доступно {2}", TotalSizeGb, TotalFreeSpaceGb, AvailableFreeSpaceGb);
        }

        public override string ToString()
        {
            return GetReadableDriveName() + ":" + DriveTypeString + "," + DriveFormat + "," + GetVolumeSizeString();
        }

        private string GetReadableDriveName()
        {
            if (DriveVolumeLabel == null || DriveVolumeLabel.Length == 0)
            {
                return "[" + DriveName + "]";
            }
            return "[" + DriveVolumeLabel + "]";
        }

        private string GetDriveTypeAsString(DriveType driveType)
        {
            switch (driveType)
            {
                case DriveType.Fixed: return "Фиксированный диск";
                case DriveType.Network: return "Сетевой диск";
                case DriveType.Removable: return "Съёмный диск";
                case DriveType.Ram: return "ОЗУ";
                case DriveType.NoRootDirectory: return "Без корневого каталога";
                case DriveType.CDRom: return "CD-ROM";
                case DriveType.Unknown: default: return "Неизвестно";
            }
        }
    }
}