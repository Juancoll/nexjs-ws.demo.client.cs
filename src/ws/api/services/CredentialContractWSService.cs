using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using nex.ws;

namespace demo.wsclient
{
    public class CredentialContractWSService<TUser, TToken>: WSServiceBase<TUser, TToken>
    {
        #region [ implement WSServiceBase ]
        public override string Name { get { return "credentialContract"; } }
        #endregion

        #region [ constructor ]
        public CredentialContractWSService(RestClient<TUser, TToken> rest, HubClient<TUser, TToken> hub)
            :base(rest, hub)
        {
            _onUpdate = new HubEventSelector<TUser, TToken, double>(hub, Name, "onUpdate");
            _onDataUpdate = new HubEventSelectorData<TUser, TToken, double, AnyData>(hub, Name, "onDataUpdate");
        }
        #endregion

        #region [ hub private ]
        private HubEventSelector<TUser, TToken, double> _onUpdate { get; }
        private HubEventSelectorData<TUser, TToken, double, AnyData> _onDataUpdate { get; }
        #endregion

        #region [ hub public ]

        // isAuth: false
        public HubEventSelector<TUser, TToken, double> onUpdate { get { return _onUpdate; } }

        // isAuth: false
        public HubEventSelectorData<TUser, TToken, double, AnyData> onDataUpdate { get { return _onDataUpdate; } }
        #endregion

        #region [ rest ]

        // isAuth: false
        public Task print() { return Request( "print", null ); }

        // isAuth: false
        public Task notify() { return Request( "notify", null ); }
        #endregion
    }
}
