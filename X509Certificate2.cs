﻿using CertificateManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Admin.IDP
{
    //public static X509Certificate2 CreateRsaCertificate(string dnsName, int validityPeriodInYears)
    //{
    //    var basicConstraints = new BasicConstraints
    //    {
    //        CertificateAuthority = false,
    //        HasPathLengthConstraint = false,
    //        PathLengthConstraint = 0,
    //        Critical = false
    //    };

    //    var subjectAlternativeName = new SubjectAlternativeName
    //    {
    //        DnsName = new List<string> { dnsName }
    //    };

    //    var x509KeyUsageFlags = X509KeyUsageFlags.DigitalSignature;

    //    // only if certification authentication is used
    //    var enhancedKeyUsages = new OidCollection
    //    {
    //        new Oid("1.3.6.1.5.5.7.3.1"),  // TLS Server auth
    //        new Oid("1.3.6.1.5.5.7.3.2"),  // TLS Client auth
    //    };

    //    var certificate = _cc.NewRsaSelfSignedCertificate(
    //        new DistinguishedName { CommonName = dnsName },
    //        basicConstraints,
    //        new ValidityPeriod
    //        {
    //            ValidFrom = DateTimeOffset.UtcNow,
    //            ValidTo = DateTimeOffset.UtcNow.AddYears(validityPeriodInYears)
    //        },
    //        subjectAlternativeName,
    //        enhancedKeyUsages,
    //        x509KeyUsageFlags,
    //        new RsaConfiguration { KeySize = 2048 }
    //    );

    //    return certificate;
    //}
}
