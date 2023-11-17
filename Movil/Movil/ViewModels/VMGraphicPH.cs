using Movil.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Movil.ViewModels
{
    public class VMGraphicPh
    {
        public ObservableCollection<MGraphicPh> Data { get; set; }


        public VMGraphicPh() 
        {
            Data = new ObservableCollection<MGraphicPh>();
            FillData();
        }

        private void FillData()
        {
            MGraphicPh objs = new MGraphicPh()
            {
                Hour = 0,
                Ph = 0
            };
            Data.Add(objs);

            MGraphicPh objs1 = new MGraphicPh()
            {
                Hour = 2,
                Ph = 2
            };
            Data.Add(objs1);

            MGraphicPh objs2 = new MGraphicPh()
            {
                Hour = 3,
                Ph = 3
            };
            Data.Add(objs2);

            MGraphicPh objs3 = new MGraphicPh()
            {
                Hour = 4,
                Ph = 7
            };
            Data.Add(objs3);

            MGraphicPh objs4 = new MGraphicPh()
            {
                Hour = 5,
                Ph = 4
            };
            Data.Add(objs4);

        }
    }
}
