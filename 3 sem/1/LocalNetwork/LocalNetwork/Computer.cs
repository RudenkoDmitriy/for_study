
namespace LocalNetwork
{
    public class Computer
    {
        /// <summary>
        /// OS - w/l/m. isInfect - 1/0. rand - random delegate.
        /// </summary>
        /// <param name="operationSystem"></param>
        /// <param name="isInfect"></param>
        /// <param name="isRand"></param>
        public Computer(char operationSystem, int isInfect, RandomDelegate rand)
        {
            this.Random = rand;
            if (operationSystem == 'w')
            {
                this.OperationSystem = OS.Windows;
            }
            if (operationSystem == 'l')
            {
                this.OperationSystem = OS.Linux;
            }
            if (operationSystem == 'm')
            {
                this.OperationSystem = OS.Mac;
            }
            this.Virus = (isInfect == 1);
            probability = 0;
        }

        /// <summary>
        /// This function use to infect computer.
        /// </summary>
        public void Infection()
        {
            if (this.Virus)
            {
                return;
            }
            if (this.probability > 50)
            {
                this.Virus = true;
                return;
            }
            if (this.OperationSystem == OS.Windows)
            {
                this.probability += probabilityWindows * this.Random() / 50;
            }
            if (this.OperationSystem == OS.Linux)
            {
                this.probability += probabilityLinux * this.Random() / 50;
            }
            if (this.OperationSystem == OS.Mac)
            {
                this.probability += probabilityMac * this.Random() / 50;
            }
        }

        public OS OperationSystem
        {
            get;
            private set;
        }

        public bool Virus
        {
            get;
            private set;
        }

        public enum OS { Windows, Linux, Mac };
        public delegate int RandomDelegate();

        private RandomDelegate Random;
        private const int probabilityWindows = 30;
        private const int probabilityLinux = 20;
        private const int probabilityMac = 15;
        private int probability;
    }
}
