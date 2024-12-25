using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_session_2_demo
{
    internal class Car
    {

        public int id {  get; set; }
        public string model {  get; set; }
        public int speed {  get; set; }

        //when i did not create a constructor clr by default creates parameterless constructor and if i create one the
        //default will be deleted
        public override string ToString()
        {
            return ("new ccar ");
        }

        #region full property

        //private int id;

        //public int Id
        //{
        //    get { return id; }
        //    set { id = value; }
        //}

        //private int model;
        //public int Model
        //{
        //    get { return model; }
        //    set { model = value; }
        //}

        //private int speed;
        //public int Speed
        //{
        //    get { return speed; }
        //    set { speed = value; }

        //}

        //public Car(int _id,int _model,int _speed)
        //{
        //    id = _id;
        //    model = _model;
        //    speed = _speed;



        //public override string ToString()
        //{
        //    return $"id is {id} \n model is {model} \n speed is {speed}";
        //}
        #endregion


    }
}