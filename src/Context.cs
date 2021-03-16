using System;
using System.Threading.Tasks;
using demo.httpclient.Api;
using demo.httpclient.Client;
using demo.httpclient.Model;
using dev.wsclient;

namespace demo.wsclient
{
    public class Context
    {
        #region [ singleton ]
        private static Context _instance;

        private Context() { }

        public static Context Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Context();
                    _instance.Initialize();
                }
                return _instance;
            }
        }
        #endregion

        #region [ class ]
        public class HttpApi
        {
            private Configuration _config = new Configuration();

            public string Url
            {
                get { return _config.BasePath; }
                set { _config.BasePath = value; }
            }

            public DefaultApi Default { get; }
            public TestApi Test { get; }
            public AuthApi Auth { get; }
            public DbDatasApi DBDatas { get; }
            public DbUsersApi DBUsers { get; }

            public HttpApi(string url)
            {
                _config.BasePath = url;
                Default = new DefaultApi(_config);
                Test = new TestApi(_config);
                Auth = new AuthApi(_config);
                DBDatas = new DbDatasApi(_config);
                DBUsers = new DbUsersApi(_config);
            }

            async public Task<AuthUserDto> LocalLogin(string email, string password)
            {
                _config.ApiClient.RestClient.CookieContainer = new System.Net.CookieContainer();
                var response = await Auth.AuthControllerLocalLoginAsync(new AuthLoginDto(email, password));           
                return response;
            }
            async public Task LocalLogout()
            {
                await Auth.AuthControllerLocalLogoutAsync();
            }
            async public Task<AuthJwtLoginResponseDto> JwtLogin(string email, string password)
            {
                var response = await Auth.AuthControllerJwtLoginAsync(new AuthLoginDto(email, password));
                _config.AddDefaultHeader("Authorization", string.Format("Bearer {0}", response.token));
                return response;
            }
            public void JwtLogout()
            {
                _config.DefaultHeader = new System.Collections.Generic.Dictionary<string, string>();
            }
        }
        #endregion

        #region [ properties ]
        public WSApi<User, string> wsapi { get; private set; }
        public HttpApi httpapi { get; private set; }
        #endregion

        #region [ private ]
        private void Initialize()
        {
            #region [ http api ]
            httpapi = new HttpApi("http://localhost:3000");
            #endregion

            #region [ ws api ]
            wsapi = new WSApi<User, string>();

            wsapi.EventWSError += (s, e) =>
            {
                Console.WriteLine($"[wsapi] EventWSError code = {e.Value.Code}, message = {e.Value.Message}");
            };

            #region [ IWSBase events ]
            wsapi.Ws.EventConnectionChange += (s, e) =>
            {
                if (e.Value)
                    Console.WriteLine($"[IWSBase] connected '{e.Value}', id = {wsapi.Ws.Id}");
                else
                    Console.WriteLine($"[IWSBase] disconnected");
            };
            wsapi.Ws.EventSubscriptionError += (s, e) =>
            {
                Console.WriteLine($"[IWSBase] EventSubscriptionError event = {e.Value.Name}, error = {e.Value.Exception.Message}");
            };
            wsapi.Ws.EventNewSocketInstance += (s, e) =>
            {
                Console.WriteLine($"[IWSBase] EventNewSocketInstance");
            };
            wsapi.Ws.EventSend += (s, e) =>
            {
                var strData = e.Value.Data == null
                    ? "null"
                    : e.Value.Data.ToString();

                Console.WriteLine($"[IWSBase] EventSend event = {e.Value.Name}, data = {strData}");
            };
            wsapi.Ws.EventReceive += (s, e) =>
            {
                var strData = e.Value.Data == null
                    ? "null"
                    : e.Value.Data.ToString();

                Console.WriteLine($"[IWSBase] EventReceive event = {e.Value.Name}, data = {strData}");
            };
            wsapi.Ws.EventNestJSException += (s, e) =>
            {
                Console.WriteLine($"[IWSBase] EventNestJSException status = {e.Value.Status}, error = {e.Value.Message}");
            };
            #endregion

            #region [ HubClient events ]
            wsapi.Hub.EventReceive += (s, e) =>
            {
                Console.WriteLine($"[HubClient] EventReceive service = {e.Value.service}, event = {e.Value.eventName}");
            };
            wsapi.Hub.EventSubscribed += (s, e) =>
            {
                Console.WriteLine($"[HubClient] EventSubscribed service = {e.Value.service}, event = {e.Value.eventName}");
            };
            wsapi.Hub.EventSubscriptionError += (s, e) =>
            {
                Console.WriteLine($"[HubClient] EventSubscriptionException service = {e.Value.Request.service}, event = {e.Value.Request.eventName}, exception = {e.Value.Exception.Message}");
            };
            #endregion
            #endregion
        }
        #endregion
    }
}
