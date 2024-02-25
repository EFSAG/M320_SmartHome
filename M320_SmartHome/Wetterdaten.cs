namespace M320_SmartHome {
    public struct Wetterdaten {
        private int v1;
        private int v2;
        private int v3;
        private bool v;

        public Wetterdaten(int v1, int v2, int v3) : this()
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }

        public Wetterdaten(int v1, int v2, bool v) : this()
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v = v;
        }

        public double Aussentemperatur { get; set; }
        public double Windgeschwindigkeit { get; set; }
        public bool Regen { get; set; }
    }
}
