using System.Web.Mvc;
using ComicBookGallery.Controllers;
// <copyright file="ComicBooksControllerFactory.cs">Copyright ©  2018</copyright>

using System;
using Microsoft.Pex.Framework;

namespace ComicBookGallery.Controllers
{
    /// <summary>A factory for ComicBookGallery.Controllers.ComicBooksController instances</summary>
    public static partial class ComicBooksControllerFactory
    {
        /// <summary>A factory for ComicBookGallery.Controllers.ComicBooksController instances</summary>
        [PexFactoryMethod(typeof(ComicBooksController))]
        public static ComicBooksController Create(
            IDependencyResolver value_iDependencyResolver,
            IActionInvoker value_iActionInvoker,
            ITempDataProvider value_iTempDataProvider,
            UrlHelper value_urlHelper,
            ViewEngineCollection value_viewEngineCollection,
            ControllerContext value_controllerContext,
            TempDataDictionary value_tempDataDictionary,
            bool value_b,
            IValueProvider value_iValueProvider,
            ViewDataDictionary value_viewDataDictionary
        )
        {
            ComicBooksController comicBooksController = new ComicBooksController();
            ((Controller)comicBooksController).Resolver = value_iDependencyResolver;
            ((Controller)comicBooksController).ActionInvoker = value_iActionInvoker;
            ((Controller)comicBooksController).TempDataProvider = value_iTempDataProvider;
            ((Controller)comicBooksController).Url = value_urlHelper;
            ((Controller)comicBooksController).ViewEngineCollection =
              value_viewEngineCollection;
            ((ControllerBase)comicBooksController).ControllerContext =
              value_controllerContext;
            ((ControllerBase)comicBooksController).TempData = value_tempDataDictionary;
            ((ControllerBase)comicBooksController).ValidateRequest = value_b;
            ((ControllerBase)comicBooksController).ValueProvider = value_iValueProvider;
            ((ControllerBase)comicBooksController).ViewData = value_viewDataDictionary;
            return comicBooksController;

            // TODO: Edit factory method of ComicBooksController
            // This method should be able to configure the object in all possible ways.
            // Add as many parameters as needed,
            // and assign their values to each field by using the API.
        }
    }
}
