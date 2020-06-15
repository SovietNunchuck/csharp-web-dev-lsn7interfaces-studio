using System;
using System.Collections.Generic;
using System.Text;

namespace SpinningDiscs
{
    interface IOpticalDisc
    {
        const int discRadiusInCm = 6;

        void SpinDisc();

        //void StoreData();

        //void WriteData();

        //void ReadData();

        void ReportData();

        //void GetScratched();
    }
}
