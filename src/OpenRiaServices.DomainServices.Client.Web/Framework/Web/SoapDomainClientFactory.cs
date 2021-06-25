using System;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using OpenRiaServices.DomainServices.Client.Web.Internal;

namespace OpenRiaServices.DomainServices.Client.Web
{
    /// <summary>
    /// For connecting to services using the /soap endpoint based on <see cref="BasicHttpBinding"/>.
    /// <para>Set <see cref="DomainContext.DomainClientFactory"/> to an instance of this class
    /// in order for newly created <see cref="DomainContext"/> implementations to use the soap endpoint.
    /// </para>
    /// </summary>
    public class SoapDomainClientFactory : WcfDomainClientFactory
    {
        private readonly WcfEndpointBehavior _soapBehavior;

        /// <summary>
        /// Initializes a new instance of the <see cref="SoapDomainClientFactory" /> class.
        /// </summary>
        public SoapDomainClientFactory()
            : base("soap")
        {
            _soapBehavior = new WcfEndpointBehavior(this);
        }

        /// <summary>
        /// Creates a channel factory for use by a DomainClient to communicate with the server using SOAP endpoint.
        /// </summary>
        /// <param name="endpoint">Absolute service URI without protocol suffix such as "/binary"</param>
        /// <param name="requiresSecureEndpoint"><c>true</c> if communication must be secured, otherwise <c>false</c></param>
        /// <returns>The channel used to communicate with the server.</returns>
        protected override ChannelFactory<TContract> CreateChannelFactory<TContract>(Uri endpoint, bool requiresSecureEndpoint)
        {
            var factory = base.CreateChannelFactory<TContract>(endpoint, requiresSecureEndpoint);

            try
            {
#if SILVERLIGHT
                factory.Endpoint.Behaviors.Add(_soapBehavior);
#else
                factory.Endpoint.EndpointBehaviors.Add(_soapBehavior);
#endif
                return factory;
            }
            catch
            {
                ((IDisposable)factory)?.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Generates a <see cref="CustomBinding"/> which is configured to speak to the
        /// "soap" endpoint
        /// </summary>
        /// <param name="endpoint">Absolute service URI without protocol suffix such as "/soap" or "/binary"</param>
        /// <param name="requiresSecureEndpoint"><c>true</c> if communication must be secured, otherwise <c>false</c></param>
        /// <returns>A <see cref="Binding"/> which is compatible with soap endpoint</returns>
        protected override Binding CreateBinding(Uri endpoint, bool requiresSecureEndpoint)
        {
            var binding = new CustomBinding();

            var textMessageEncodingEl = new TextMessageEncodingBindingElement(MessageVersion.Soap11, Encoding.UTF8);
            binding.Elements.Add(textMessageEncodingEl);

            var element = new HttpTransportBindingElement();

            if (endpoint.Scheme == Uri.UriSchemeHttps)
            {
                element = new HttpsTransportBindingElement();
            }
            else if (requiresSecureEndpoint)
            {
                throw new InvalidOperationException("use https to connect to secure endpoint");
            }

            element.MaxReceivedMessageSize = int.MaxValue;
#if SILVERLIGHT
            elements.EnableHttpCookieContainer =  CookieContainer != null;
#else
            element.AllowCookies = CookieContainer != null;
#endif
            binding.Elements.Add(element);

            return binding;
        }
    }
}
