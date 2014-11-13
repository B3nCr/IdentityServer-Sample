IdentityServer v3 Sample
=====================

This application cosists of an ASP.NET MVC/WebApi project and a single page app. There is also an extra API to test CORS.

I wanted to work out how to host AngularJS in an ASP.NET MVC application and use cookie authentication for the MVC views but prevent cookies being used by the API in the same project.

The sample contains my own hard coded urls and my own hard coded certificate thumbprint. You can either leave the URLs or change them. If you don't already know how to generate your own certificates I suggest this helpful blog post, http://www.jayway.com/2014/09/03/creating-self-signed-certificates-with-makecert-exe-for-development.

This all worked as of Identity Server beta-2 (I think).
