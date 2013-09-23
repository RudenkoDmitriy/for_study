
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
        public Computer(char operationSystem, int isInfect, bool isRand)
        {
            if (isRand)
                this.rand = new System.Random();
            else
                this.rand = new System.Random(1565456);
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
            int tRand = this.rand.Next(0, 100);
            if (this.probability > 50)
            {
                this.Virus = true;
                return;
            }
            if (this.OperationSystem == OS.Windows)
            {
                this.probability += probabilityWindows * tRand / 50;
            }
            if (this.OperationSystem == OS.Linux)
            {
                this.probability += probabilityLinux * tRand / 50;
            }
            if (this.OperationSystem == OS.Mac)
            {
                this.probability += probabilityMac * tRand / 50;
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
        private int  probabilityWindows = 30;
        private int probabilityLinux = 20;
        private int probabilityMac = 15;
        private int probability;
    }
}
