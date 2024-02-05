using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Delegates_In_Action
{
    class Suzanne
    {
        public GetSecretIngredient MySecretIngredientMethod
        {
            get
            {
                return new GetSecretIngredient(suzannesSecretIngredient);                
            }
        }

        private string suzannesSecretIngredient(int amount)
        {
            return amount.ToString() + "ounces of cloves";
        }

    }
}
