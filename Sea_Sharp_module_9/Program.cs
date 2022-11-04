using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Sea_Sharp_module_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }


    public class ConfigChild1
    {
        private bool _StartBegin;
        private int _CircleThis;
        private int _Count;
        private int _StringMatchNumber;
        private string _TimeCount;

        [XmlAttribute]
        public bool StartBegin
        {
            get { return _StartBegin; }
            set { _StartBegin = value; }
        }


        [XmlAttribute]
        public int CircleThis

        {
            get { return _CircleThis; }
            set { _CircleThis = value; }
        }


        [XmlAttribute]
        public int Count
        {
            get { return _Count; }
            set { _Count = value; }
        }

        [XmlAttribute]
        public int StringMatchNumber
        {
            get { return _StringMatchNumber; }
            set { _StringMatchNumber = value; }
        }


        [XmlAttribute]
        public string TimeCount
        {
            get { return _TimeCount; }
            set { _TimeCount = value; }
        }



        //два конструктора
        public ConfigChild1(bool _startBegin, int _circleThis, int _count, int _stringMatchNumber, string _timeCount)
        {
            StartBegin = _startBegin;
            CircleThis = _circleThis;
            Count = _count;
            StringMatchNumber = _stringMatchNumber;
            TimeCount = _timeCount;

        }

        //Открытый конструктор без параметров является необходимым для сериализации
        public ConfigChild1()
        {

        }
    }
    
}
