using Console_test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    public class TestCalculo
    {
        //AAA : Arrange,Act, Assert
        // AAA : Organizar, Agir, Assertir <summary>
       
       
        //Funciona para que o comando rode
        [Fact]

        //criou uma variavel
        public void CalcSoma()
        {
            //tras o valor um da soma
            var x1 = 10;

            //traz o valor dois da soma
            var x2 = 20;

            //tras o resultado da soma
            var result = 30;


            //act
            var chamarMetodo = Calculo.Soma(x1, x2);

            //assert
            Assert.Equal(result, chamarMetodo);
        }

        [Fact]
        public void CalcSub()
        {
            var x1 = 90;

            var x2 = 45;

            var result = 45;

            var chamarMetodo = Calculo.Subtracao(x1, x2);

            Assert.Equal(result, chamarMetodo);

        }

        [Fact]
        public void CalcDiv()
        {
            var x1 = 25;

            var x2 = 5;

            var result = 5;

            var ChamarMetodo = Calculo.Divisao(x1, x2);

            Assert.Equal(result, ChamarMetodo);
        }

        [Fact]
        public void CalcMult()
        {
            var x1 = 50;

            var x2 = 5;

            var result = 250;

            var ChamarMetodo = Calculo.Multiplicacao(x1, x2);

            Assert.Equal(result, ChamarMetodo);
        }
    }
}
