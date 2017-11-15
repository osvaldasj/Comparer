using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparer.AdditionalFeatures
{
    public class TestControllerModel
    {
        public string currentText { set; get; }


        public TestControllerModel(string v)
        {
            currentText = v;
        }

        public TestControllerModel()
        {
            
        }

    }
}
