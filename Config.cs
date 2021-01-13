// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityServer4;
using IdentityServer4.Models;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace Admin.IDP
{
    public static class Config
    {
        public static IEnumerable<IdentityResource> Ids =>
            new IdentityResource[]
            {
                //Some standard scopes from the OIDC spec
                new IdentityResources.Email(),
                new IdentityResources.OpenId(),
                new IdentityResources.Profile()
            };


        public static IEnumerable<ApiResource> Apis =>
            new ApiResource[]
            {
                new ApiResource("collectorapi", "Tax Collector System API")
                {
                    ApiSecrets = { new Secret("8605F64B977C42B184559708CDF6237C".Sha256()) }
                },
            };


        //public static IEnumerable<ApiScope> GetApiScopes() =>
        //    new List<ApiScope>
        //    {
        //        new ApiScope("collectorapi", "Tax Collector System API"),
        //        new ApiScope("email", "email scope"),
        //        new ApiScope("openid", "openid scope"),
        //        new ApiScope("profile", "profile scope")
        //    };


        public static IEnumerable<Client> Clients(IConfiguration configuration) =>
            new Client[]
            {
                // Client for the Tax Collector Swagger API application
                new Client
                {
                    ClientId = "TaxCollectorImplicit",
                    ClientName = "Tax Collector Implicit",
                    AllowedGrantTypes = GrantTypes.Implicit,

                    AllowedScopes = new [] {
                        IdentityServerConstants.StandardScopes.Email,
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        "collectorapi"
                    },
                    RequireConsent = false,
                    AllowAccessTokensViaBrowser = true,
                    AlwaysIncludeUserClaimsInIdToken = false,
                    AllowOfflineAccess = true,
                    AllowedCorsOrigins = new []
                    {
                        "http://localhost:58199",
                        "http://psl-app-vm3/TaxCollectorAdminAPI",
                        "http://localhost:50456",
                        "http://psl-app-vm3/TaxCollectorAPI"
                    },
                    RedirectUris =  new []
                    {
                        "http://localhost:58199",
                        "http://psl-app-vm3/TaxCollectorAdminAPI",
                        "http://localhost:50456",
                        "http://psl-app-vm3/TaxCollectorAPI",

                        "http://localhost:58199/swagger/oauth2-redirect.html",
                        "http://psl-app-vm3/TaxCollectorAdminAPI/swagger/oauth2-redirect.html",
                        "http://localhost:50456/swagger/oauth2-redirect.html",
                        "http://psl-app-vm3/TaxCollectorAPI/swagger/oauth2-redirect.html"
                    },
                    PostLogoutRedirectUris =
                    {
                        "http://localhost:58199/swagger",
                        "http://psl-app-vm3/TaxCollectorAdminAPI/swagger",
                        "http://localhost:50456/swagger",
                        "http://psl-app-vm3/TaxCollectorAPI/swagger",
                        "http://localhost:58199",
                        "http://psl-app-vm3/TaxCollectorAdminAPI",
                        "http://localhost:50456",
                        "http://psl-app-vm3/TaxCollectorAPI"
                    }
                },

                // OpenID Connect hybrid flow client (MVC)
                new Client
                {
                    ClientId = "TaxCollectorHybrid",
                    ClientName = "Tax Collector Hybrid",
                    AllowedGrantTypes = GrantTypes.Hybrid,
                    AlwaysIncludeUserClaimsInIdToken = false,
                    RequireConsent = false,
                    ClientSecrets =
                    {
                        new Secret("8605F64B977C42B184559708CDF6237C".Sha256())
                    },

                    RedirectUris           = new []
                    {
                        "http://localhost:58199/signin-oidc",
                        "http://psl-app-vm3/TaxCollectorAdminAPI/signin-oidc",
                        "http://localhost:50456/signin-oidc",
                        "http://psl-app-vm3/TaxCollectorAPI/signin-oidc",
                        "http://localhost:58199/swagger/signin-oidc",
                        "http://psl-app-vm3/TaxCollectorAdminAPI/swagger/signin-oidc",
                        "http://localhost:50456/swagger/signin-oidc",
                        "http://psl-app-vm3/TaxCollectorAPI/swagger/signin-oidc"
                    },
                    PostLogoutRedirectUris = new []
                    {
                        "http://localhost:58199/signout-callback-oidc",
                        "http://psl-app-vm3/TaxCollectorAdminAPI/signout-callback-oidc",
                        "http://localhost:50456/signout-callback-oidc",
                        "http://psl-app-vm3/TaxCollectorAPI/signout-callback-oidc",
                        "http://localhost:58199/swagger/signout-callback-oidc",
                        "http://psl-app-vm3/TaxCollectorAdminAPI/swagger/signout-callback-oidc",
                        "http://localhost:50456/swagger/signout-callback-oidc",
                        "http://psl-app-vm3/TaxCollectorAPI/swagger/signout-callback-oidc"
                    },

                    AllowedScopes =
                    {
                        IdentityServerConstants.StandardScopes.Email,
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        "collectorapi"
                    },

                    AllowOfflineAccess = true
                },

                // Client using code flow + pkce for the mobile device
                new Client
                {
                    ClientId = "TaxMobileCode",
                    ClientName = "Tax Mobile Code",

                    AllowedGrantTypes = GrantTypes.Code,
                    AlwaysIncludeUserClaimsInIdToken = false,
                    RequirePkce = true,
                    RequireClientSecret = false,
                    RequireConsent = false,
                    RedirectUris = new []
                    {
                        "http://localhost:58199/signin-oidc",
                        "http://psl-app-vm3/TaxCollectorAdminAPI/signin-oidc",
                        "http://localhost:50456/signin-oidc",
                        "http://psl-app-vm3/TaxCollectorAPI/signin-oidc",
                        "http://localhost:58199/swagger/signin-oidc",
                        "http://psl-app-vm3/TaxCollectorAdminAPI/swagger/signin-oidc",
                        "http://localhost:50456/swagger/signin-oidc",
                        "http://psl-app-vm3/TaxCollectorAPI/swagger/signin-oidc"
                    },

                    PostLogoutRedirectUris = new []
                    {
                        "http://localhost:58199/signout-callback-oidc",
                        "http://psl-app-vm3/TaxCollectorAdminAPI/signout-callback-oidc",
                        "http://localhost:50456/signout-callback-oidc",
                        "http://psl-app-vm3/TaxCollectorAPI/signout-callback-oidc",
                        "http://localhost:58199/swagger/signout-callback-oidc",
                        "http://psl-app-vm3/TaxCollectorAdminAPI/swagger/signout-callback-oidc",
                        "http://localhost:50456/swagger/signout-callback-oidc",
                        "http://psl-app-vm3/TaxCollectorAPI/swagger/signout-callback-oidc"
                    },
                    AllowedCorsOrigins = new []
                    {
                        "http://localhost:58199",
                        "http://psl-app-vm3/TaxCollectorAdminAPI",
                        "http://localhost:50456",
                        "http://psl-app-vm3/TaxCollectorAPI",
                        "http://localhost:58199/swagger",
                        "http://psl-app-vm3/TaxCollectorAdminAPI/swagger",
                        "http://localhost:50456/swagger",
                        "http://psl-app-vm3/TaxCollectorAPI/swagger"
                    },

                    AllowedScopes = {
                        IdentityServerConstants.StandardScopes.Email,
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        "collectorapi"
                    }
                },

                // Client for the Tax Admin API application
                new Client
                {
                    ClientId = "TaxAdminCode",
                    ClientName = "Tax Admin Code",
                    //ClientSecrets =
                    //{
                    //    new Secret("8605F64B977C42B184559708CDF6237C".Sha256())
                    //},
                    AllowedGrantTypes = GrantTypes.Code,
                    //AlwaysIncludeUserClaimsInIdToken = false,
                    RequirePkce = false,
                    RequireClientSecret = false,
                    RequireConsent = false,
                    RedirectUris = new []
                    {
                        "http://localhost:58199/signin-oidc",
                        "http://psl-app-vm3/TaxCollectorAdminAPI/signin-oidc",
                        "http://localhost:50456/signin-oidc",
                        "http://psl-app-vm3/TaxCollectorAPI/signin-oidc",
                        "http://localhost:58199/swagger/signin-oidc",
                        "http://psl-app-vm3/TaxCollectorAdminAPI/swagger/signin-oidc",
                        "http://localhost:50456/swagger/signin-oidc",
                        "http://psl-app-vm3/TaxCollectorAPI/swagger/signin-oidc"
                    },

                    PostLogoutRedirectUris = new []
                    {
                        "http://localhost:58199/signout-callback-oidc",
                        "http://psl-app-vm3/TaxCollectorAdminAPI/signout-callback-oidc",
                        "http://localhost:50456/signout-callback-oidc",
                        "http://psl-app-vm3/TaxCollectorAPI/signout-callback-oidc",
                        "http://localhost:58199/swagger/signout-callback-oidc",
                        "http://psl-app-vm3/TaxCollectorAdminAPI/swagger/signout-callback-oidc",
                        "http://localhost:50456/swagger/signout-callback-oidc",
                        "http://psl-app-vm3/TaxCollectorAPI/swagger/signout-callback-oidc"
                    },
                    AllowedCorsOrigins = new []
                    {
                        "http://localhost:58199",
                        "http://psl-app-vm3/TaxCollectorAdminAPI",
                        "http://localhost:50456",
                        "http://psl-app-vm3/TaxCollectorAPI",
                        "http://localhost:58199/swagger",
                        "http://psl-app-vm3/TaxCollectorAdminAPI/swagger",
                        "http://localhost:50456/swagger",
                        "http://psl-app-vm3/TaxCollectorAPI/swagger"
                    },

                    AllowedScopes = {
                        IdentityServerConstants.StandardScopes.Email,
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        "collectorapi"
                    }
                },

                // Client for the Tax Collector API application
                new Client
                {
                    ClientId = "TaxCollectorCode",
                    ClientName = "Tax Collector Code",

                    AllowedGrantTypes = GrantTypes.Code,
                    AlwaysIncludeUserClaimsInIdToken = false,
                    RequirePkce = true,
                    RequireClientSecret = false,
                    RequireConsent = false,
                    RedirectUris = new []
                    {
                        "http://localhost:58199/signin-oidc",
                        "http://psl-app-vm3/TaxCollectorAdminAPI/signin-oidc",
                        "http://localhost:50456/signin-oidc",
                        "http://psl-app-vm3/TaxCollectorAPI/signin-oidc",
                        "http://localhost:58199/swagger/signin-oidc",
                        "http://psl-app-vm3/TaxCollectorAdminAPI/swagger/signin-oidc",
                        "http://localhost:50456/swagger/signin-oidc",
                        "http://psl-app-vm3/TaxCollectorAPI/swagger/signin-oidc"
                    },

                    PostLogoutRedirectUris = new []
                    {
                        "http://localhost:58199/signout-callback-oidc",
                        "http://psl-app-vm3/TaxCollectorAdminAPI/signout-callback-oidc",
                        "http://localhost:50456/signout-callback-oidc",
                        "http://psl-app-vm3/TaxCollectorAPI/signout-callback-oidc",
                        "http://localhost:58199/swagger/signout-callback-oidc",
                        "http://psl-app-vm3/TaxCollectorAdminAPI/swagger/signout-callback-oidc",
                        "http://localhost:50456/swagger/signout-callback-oidc",
                        "http://psl-app-vm3/TaxCollectorAPI/swagger/signout-callback-oidc"
                    },
                    AllowedCorsOrigins = new []
                    {
                        "http://localhost:58199",
                        "http://psl-app-vm3/TaxCollectorAdminAPI",
                        "http://localhost:50456",
                        "http://psl-app-vm3/TaxCollectorAPI",
                        "http://localhost:58199/swagger",
                        "http://psl-app-vm3/TaxCollectorAdminAPI/swagger",
                        "http://localhost:50456/swagger",
                        "http://psl-app-vm3/TaxCollectorAPI/swagger"
                    },

                    AllowedScopes = {
                        IdentityServerConstants.StandardScopes.Email,
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        "collectorapi"
                    }
                },

                new Client
                {
                    ClientId = "m2m",
                    ClientName = "Machine to machine (client credentials)",
                    ClientSecrets = { new Secret("7359E6A34BDA4794B19B8738CBBBEDB3".Sha256()) },

                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    AllowedScopes = { "collectorapi" },
                    AlwaysIncludeUserClaimsInIdToken = false
                },

                // Client for the Tax Mobile Native Code application
                new Client
                {
                    ClientId = "TaxCollectorNativeCode",
                    ClientName = "Tax Collector Native Client (Code with PKCE)",

                    RedirectUris = { "com.persol.net.persolrevenueassurance:/oauth2callback" },
                    PostLogoutRedirectUris = { "https://notused" },

                    RequireClientSecret = false,
                    RequireConsent = false,

                    AllowedGrantTypes = GrantTypes.CodeAndClientCredentials,
                    AlwaysIncludeUserClaimsInIdToken = false,
                    RequirePkce = true,
                    //AllowedScopes = { "openid", "profile", "email", "api" },
                    AllowedScopes = new [] {
                        IdentityServerConstants.StandardScopes.Email,
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        "collectorapi"
                    },

                    AllowOfflineAccess = true,
                    RefreshTokenUsage = TokenUsage.ReUse
                },

                // Client for the Tax Mobile Native Code application (2)
                new Client
                {
                    ClientId = "TaxCollectorAndroidCode",
                    ClientName = "Tax Collector Android Client (Code with PKCE)",

                    RedirectUris = { "com.pluto.net.pds:/oauth2callback" },
                    PostLogoutRedirectUris = { "https://notused" },

                    RequireClientSecret = false,
                    RequireConsent = false,

                    AllowedGrantTypes = GrantTypes.CodeAndClientCredentials,
                    AlwaysIncludeUserClaimsInIdToken = false,
                    RequirePkce = true,
                    //AllowedScopes = { "openid", "profile", "email", "api" },
                    AllowedScopes = new [] {
                        IdentityServerConstants.StandardScopes.Email,
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        "collectorapi"
                    },

                    AllowOfflineAccess = true,
                    RefreshTokenUsage = TokenUsage.ReUse
                },

                // Client for the Tax Web Form Code application
                new Client
                {
                    ClientId = "TaxCollectorWebFormOwinCode",
                    ClientName = "Tax Collector Web Form Owin Code",
                    AllowedGrantTypes = GrantTypes.Code,
                    AlwaysIncludeUserClaimsInIdToken = false,
                    ClientSecrets = {new Secret("8605F64B977C42B184559708CDF6237C".Sha256())},
                    RedirectUris = {"http://localhost:58199/"},
                    //AllowedScopes = {"openid", "profile", "api1"},
                    AllowedScopes = new [] {
                        IdentityServerConstants.StandardScopes.Email,
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        "collectorapi"
                    },
                    AllowPlainTextPkce = false,
                    RequirePkce = true
                }
            };
    }
}