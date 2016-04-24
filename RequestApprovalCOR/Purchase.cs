using System;

namespace RequestApprovalCOR {
    class Purchase {
        private int _number;
        private double _amount;
        private string _purpose;

        public Purchase(int number, double amount, string purpose) {
            this._number=number;
            this._amount=amount;
            this._purpose=purpose;
        }
        public int Number {
            get { return _number; }
            set { this.Number=value; }
        }
        public double Amount {
            get { return _amount; }
            set { this.Amount=value; }
        }
        public String Purpose {
            get { return _purpose; }
            set { this._purpose=value; }
        }
    }
}