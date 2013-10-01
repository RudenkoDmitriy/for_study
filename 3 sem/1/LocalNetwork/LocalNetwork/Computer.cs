
namespace LocalNetwork
{
    public class Computer
    {
        /// <summary>
        /// OS - w/l/m. isInfect - 1/0. isRand - Real/ Not Real Random.
        /// </summary>
        /// <param name="operationSystem"></param>
        /// <param name="isInfect"></param>
        /// <param name="isRand"></param>
        public Computer(char operationSystem, int isInfect)
        {
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
        public void Infection(int random)
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
                this.probability += probabilityWindows * random / 50;
            }
            if (this.OperationSystem == OS.Linux)
            {
                this.probability += probabilityLinux * random / 50;
            }
            if (this.OperationSystem == OS.Mac)
            {
                this.probability += probabilityMac * random / 50;
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

        private System.Random rand;
        private const int probabilityWindows = 30;
        private const int probabilityLinux = 20;
        private const int probabilityMac = 15;
        private int probability;
    }
}
