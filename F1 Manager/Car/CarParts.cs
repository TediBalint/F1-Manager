using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace F1_Manager.Car
{
    public class FrontWing
    {
        //Front Downforce Only
        public FrontDownForce downForce;
        public Drag drag;
        public Flex flex;
        public Durability durability;
        Image wingImage { get; set; }
        public FrontWing(FrontDownForce downForce_, Drag drag_, Flex flex_, Durability durability_, Image wingImage_)
        {
            downForce = downForce_;
            drag = drag_;
            flex = flex_;
            durability = durability_;
            wingImage = wingImage_;
        }
        public void GetDownForce()
        {

        }
    }

}
