using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using nex.ws;

namespace dev.wsclient
{
    public class BaseContractWSService<TUser, TToken>: WSServiceBase<TUser, TToken>
    {
        #region [ implement WSServiceBase ]
        public override string Name { get { return "baseContract"; } }
        #endregion

        #region [ constructor ]
        public BaseContractWSService(RestClient<TUser, TToken> rest, HubClient<TUser, TToken> hub)
            :base(rest, hub)
        {
            _onUpdate = new HubEvent<TUser, TToken>(hub, Name, "onUpdate");
            _onDataUpdate = new HubEventData<TUser, TToken, AnyData>(hub, Name, "onDataUpdate");
        }
        #endregion

        #region [ hub private ]
        private HubEvent<TUser, TToken> _onUpdate { get; }
        private HubEventData<TUser, TToken, AnyData> _onDataUpdate { get; }
        #endregion

        #region [ hub public ]

        // isAuth: false
        public HubEvent<TUser, TToken> onUpdate { get { return _onUpdate; } }

        // isAuth: false
        public HubEventData<TUser, TToken, AnyData> onDataUpdate { get { return _onDataUpdate; } }
        #endregion

        #region [ rest ]

        // isAuth: false
        public Task print() { return Request( "print", null ); }

        // isAuth: false
        public Task<double> delay(double value) { return Request<double>( "delay", value ); }

        // isAuth: false
        public Task notify() { return Request( "notify", null ); }
        #endregion
    }
}
