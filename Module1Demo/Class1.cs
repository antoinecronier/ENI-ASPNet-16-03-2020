using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1Demo
{
    public class Class1
    {
        #region A ne pas faire
        public int prop1;

        // Version Java
        private int prop2;

        public void setProp2(int prop2)
        {
            this.prop2 = prop2;
        }

        public int getProp2()
        {
            return this.prop2;
        }
        #endregion

        #region Properties
        // Utiliser les snippets
        // propfull

        //Variable de classe privé.
        private int myVar;

        // Propriété de myVar pour l'exposition publique.
        public int MyProperty
        {
            get { return myVar; }
            set {
                if (value > 10)
                {
                    myVar = 10;
                }
                else
                {
                    myVar = value;
                }
            }
        }

        // prop
        // Auto-property
        public int MyProperty1 { get; set; }

        // Readonly prop
        public int MyProperty2 { get; }
        #endregion

        #region Constructeur
        public Class1 (int test)
        {
            this.MyProperty = test;
        }

        //Snippet constructeur vide ctor
        public Class1()
        {
            this.MyProperty2 = 5;
        }
        #endregion
    }
}
