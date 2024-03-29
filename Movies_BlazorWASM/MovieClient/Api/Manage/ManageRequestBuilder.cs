// <auto-generated/>
using KiotaMovies.Client.Api.Manage.Info;
using KiotaMovies.Client.Api.Manage.Twofa;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace KiotaMovies.Client.Api.Manage {
    /// <summary>
    /// Builds and executes requests for operations under \api\manage
    /// </summary>
    public class ManageRequestBuilder : BaseRequestBuilder {
        /// <summary>The info property</summary>
        public InfoRequestBuilder Info { get =>
            new InfoRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Twofa property</summary>
        public TwofaRequestBuilder Twofa { get =>
            new TwofaRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new ManageRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ManageRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/manage", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new ManageRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ManageRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/manage", rawUrl) {
        }
    }
}
