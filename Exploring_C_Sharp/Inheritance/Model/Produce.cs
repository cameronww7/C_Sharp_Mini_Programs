﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Model
{
    class Produce
    {

        public Produce()
        {
        }

        public Produce(string name, double weight, int quantity)
        {
            Name = name;
            Weight = weight;
            Quantity = quantity;
        }

        private string name;
        public string Name
        {
            get { return name.ToUpper(); }
            set { name = value; }
        }

        private double weight;
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public int Quantity { get; set; }

        public override string ToString()
        {
            return Name + " (" + Weight + "oz) :" + Quantity;
        }

    }

    class Fruit : Produce // this class inherts Produce
    {
        public Fruit()
        {

        }
        public Fruit(string name, double weight, int quantity) :
            base(name, weight, quantity) 
        { // pass name, Weight, quantity to the base class

        }
    }

    class Vegetable : Produce // this class inherts Produce
    {
        public Vegetable()
        {

        }
        public Vegetable(string name, double weight, int quantity) :
            base(name, weight, quantity)
        { // pass name, Weight, quantity to the base class

        }

    }
}