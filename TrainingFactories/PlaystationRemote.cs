using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingFactories {
    public class PlaystationRemote : Remote {
        private readonly string _remoteType;
        private readonly string _company;

        public PlaystationRemote(bool wired, bool batteries, string compnay) {
            _remoteType = "Playstation";
            _company = Company;
            this.Wire = wired ? new PSWire() : null;
            this.Batteries = batteries ? new PSBaterries() : null;

        }

        public override string RemoteType {
            get { return _remoteType; }
        }

        public override string Company
        {
            get { return _company;  }
            set { _company = value;  }
        }

    }
}
