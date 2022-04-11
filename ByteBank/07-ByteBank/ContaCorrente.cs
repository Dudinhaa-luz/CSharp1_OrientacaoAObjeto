namespace _07_ByteBank
{
    class ContaCorrente
    {
        private Cliente _titular;

        public Cliente Titular { get; set; }
        public int Agencia { get; set; }
        public int Numero { get; set; }
        public static int TotalDeContasCriadas { get; private set; }

        private double _saldo;
        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                _saldo = value; //value substitui o parâmetro do set
            }
        }

        public ContaCorrente(int agencia, int numero)
        {
            Agencia = agencia;
            Numero  = numero;

            TotalDeContasCriadas++;
        }

    //Encapsulamento
    /*  public double GetSaldo()
        {
            return saldo;
        }

        public void SetSaldo(double saldo)
        {
            if(saldo < 0)
            {
                return;
            }
            this.saldo = saldo;
        }
    */
        public bool Sacar(double valor)
        {
            if (_saldo < valor)
                return false;

            this._saldo -= valor;
            return true;
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (_saldo < valor)
                return false;

            _saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }
    }
}