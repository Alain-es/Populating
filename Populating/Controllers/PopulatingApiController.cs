using System;
using System.Web;
using System.Web.Mvc;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;
using System.Dynamic;
using System.ComponentModel;
using System.Text;

using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;

using Umbraco.Web.Editors;
using Umbraco.Web.Mvc;
using Umbraco.Web.WebApi;

using Populating.Models;

namespace Populating.Controllers
{
    [PluginController("Populating")]
    [IsBackOffice]
    public class PopulatingApiController : UmbracoAuthorizedJsonController
    {

    }
}

