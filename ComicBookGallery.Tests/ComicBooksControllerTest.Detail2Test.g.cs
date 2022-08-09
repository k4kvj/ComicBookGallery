using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;
using ComicBookGallery.Controllers;
using Microsoft.Pex.Framework.Generated;
// <copyright file="ComicBooksControllerTest.Detail2Test.g.cs">Copyright ©  2018</copyright>
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace ComicBookGallery.Controllers.Tests
{
    public partial class ComicBooksControllerTest
    {

[TestMethod]
[PexGeneratedBy(typeof(ComicBooksControllerTest))]
public void Detail2Test24701()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      ComicBooksController comicBooksController;
      ActionResult actionResult;
      comicBooksController = ComicBooksControllerFactory.Create
                                 ((IDependencyResolver)null, (IActionInvoker)null, 
                                  (ITempDataProvider)null, (UrlHelper)null, (ViewEngineCollection)null, 
                                  (ControllerContext)null, (TempDataDictionary)null, 
                                  false, (IValueProvider)null, (ViewDataDictionary)null);
      disposables.Add((IDisposable)comicBooksController);
      actionResult = this.Detail2Test(comicBooksController);
      disposables.Dispose();
      Assert.IsNotNull((object)actionResult);
      Assert.IsNotNull((object)comicBooksController);
      Assert.IsNotNull(((Controller)comicBooksController).AsyncManager);
      Assert.IsNotNull
          (((Controller)comicBooksController).AsyncManager.OutstandingOperations);
      Assert.IsNotNull(((Controller)comicBooksController).AsyncManager.Parameters);
      Assert.AreEqual<int>
          (45000, ((Controller)comicBooksController).AsyncManager.Timeout);
      Assert.IsNull(((Controller)comicBooksController).Url);
      Assert.IsNull(((ControllerBase)comicBooksController).ControllerContext);
      Assert.AreEqual<bool>
          (false, ((ControllerBase)comicBooksController).ValidateRequest);
    }
}
    }
}
