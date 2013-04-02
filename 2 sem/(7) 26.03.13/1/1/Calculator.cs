
namespace _1
{
    public class Calculator
    {
        public Calculator()
        {
            sign = 'n';
        }

        /// <summary>
        /// This function using for add two-digit three-digit etc number. 
        /// It call if click '0' - '9'.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public int GetNewNumber(int num)
        {
            currentNumber = currentNumber * 10 + num;
            return currentNumber;
        }

        /// <summary>
        /// Assign current number = 0. This function call if click 'Reset'.
        /// </summary>
        public void Reset()
        {
            currentNumber = 0;
        }

        /// <summary>
        /// Return current number.
        /// </summary>
        /// <returns></returns>
        public int GetNumber()
        {
            return currentNumber;
        }

        /// <summary>
        /// This function using for count. It call if click '='.
        /// </summary>
        /// <param name="sign"></param>
        public void Count()
        {
            if (sign == 'n')
                return;
            int num1 = tempNumberForCount;
            int num2 = currentNumber;
            tempNumberForCount = 0;
            if (this.sign == '-')
                currentNumber = num1 - num2;
            if (this.sign == '+')
                currentNumber = num1 + num2;
            if (this.sign == '*')
                currentNumber = num1 * num2;
            if (this.sign == '/')
                currentNumber = num1 / num2;
            sign = 'n';
        }

        /// <summary>
        /// This function call if click '+'.
        /// </summary>
        public void Add()
        {
            AddNewNumber();
            sign = '+';
        }

        /// <summary>
        /// This function call if click '-'.
        /// </summary>
        public void Subtract()
        {
            AddNewNumber();
            sign = '-';
        }

        /// <summary>
        /// This function call if click '*'.
        /// </summary>
        public void Miltiply()
        {
            AddNewNumber();
            sign = '*';
        }

        /// <summary>
        /// This function call if click '/'.
        /// </summary>
        public void Divide()
        {
            AddNewNumber();
            sign = '/';
        }

        private void AddNewNumber()
        {
            tempNumberForCount = currentNumber;
            currentNumber = 0;
        }
        private int currentNumber;
        private int tempNumberForCount;
        private char sign;
    }
}
