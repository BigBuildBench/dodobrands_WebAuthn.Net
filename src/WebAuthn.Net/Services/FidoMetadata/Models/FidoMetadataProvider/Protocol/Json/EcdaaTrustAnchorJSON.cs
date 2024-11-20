﻿using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace WebAuthn.Net.Services.FidoMetadata.Models.FidoMetadataProvider.Protocol.Json;

/// <summary>
///     ECDAA Trust Anchor dictionary
/// </summary>
/// <remarks>
///     <para>
///         <a href="https://fidoalliance.org/specs/mds/fido-metadata-statement-v3.0-ps-20210518.html#ecdaatrustanchor-dictionary">FIDO Metadata Statement - §3.9. EcdaaTrustAnchor dictionary</a>
///     </para>
///     <para>
///         Whenever a party uses this trust anchor for the first time, it must first verify that it was correctly generated by verifying \(s, sx, sy\). See
///         <a href="https://fidoalliance.org/specs/fido-v2.0-id-20180227/fido-ecdaa-algorithm-v2.0-id-20180227.html">[FIDOEcdaaAlgorithm]</a> for details.
///     </para>
/// </remarks>
// ReSharper disable once InconsistentNaming
public class EcdaaTrustAnchorJSON
{
    /// <summary>
    ///     Constructs <see cref="EcdaaTrustAnchorJSON" />.
    /// </summary>
    /// <param name="x">base64url encoding of the result of ECPoint2ToB of the ECPoint2 \(X = P_2^x\). See <a href="https://fidoalliance.org/specs/fido-v2.0-id-20180227/fido-ecdaa-algorithm-v2.0-id-20180227.html">[FIDOEcdaaAlgorithm]</a> for the definition of ECPoint2ToB.</param>
    /// <param name="y">base64url encoding of the result of ECPoint2ToB of the ECPoint2 \(Y = P_2^y\). See <a href="https://fidoalliance.org/specs/fido-v2.0-id-20180227/fido-ecdaa-algorithm-v2.0-id-20180227.html">[FIDOEcdaaAlgorithm]</a> for the definition of ECPoint2ToB.</param>
    /// <param name="c">
    ///     base64url encoding of the result of BigNumberToB(\(c\)). See section "Issuer Specific ECDAA Parameters" in <a href="https://fidoalliance.org/specs/fido-v2.0-id-20180227/fido-ecdaa-algorithm-v2.0-id-20180227.html">[FIDOEcdaaAlgorithm]</a> for an explanation of
    ///     \(c\). See <a href="https://fidoalliance.org/specs/fido-v2.0-id-20180227/fido-ecdaa-algorithm-v2.0-id-20180227.html">[FIDOEcdaaAlgorithm]</a> for the definition of BigNumberToB.
    /// </param>
    /// <param name="sx">
    ///     base64url encoding of the result of BigNumberToB(\(sx\)). See section "Issuer Specific ECDAA Parameters" in <a href="https://fidoalliance.org/specs/fido-v2.0-id-20180227/fido-ecdaa-algorithm-v2.0-id-20180227.html">[FIDOEcdaaAlgorithm]</a> for an explanation of
    ///     \(sx\). See <a href="https://fidoalliance.org/specs/fido-v2.0-id-20180227/fido-ecdaa-algorithm-v2.0-id-20180227.html">[FIDOEcdaaAlgorithm]</a> for the definition of BigNumberToB.
    /// </param>
    /// <param name="sy">
    ///     base64url encoding of the result of BigNumberToB(\(sy\)). See section "Issuer Specific ECDAA Parameters" in <a href="https://fidoalliance.org/specs/fido-v2.0-id-20180227/fido-ecdaa-algorithm-v2.0-id-20180227.html">[FIDOEcdaaAlgorithm]</a> for an explanation of
    ///     \(sy\). See <a href="https://fidoalliance.org/specs/fido-v2.0-id-20180227/fido-ecdaa-algorithm-v2.0-id-20180227.html">[FIDOEcdaaAlgorithm]</a> for the definition of BigNumberToB.
    /// </param>
    /// <param name="g1Curve">
    ///     Name of the Barreto-Naehrig elliptic curve for G1. "BN_P256", "BN_P638", "BN_ISOP256", and "BN_ISOP512" are supported. See section "Supported Curves for ECDAA" in
    ///     <a href="https://fidoalliance.org/specs/fido-v2.0-id-20180227/fido-ecdaa-algorithm-v2.0-id-20180227.html">[FIDOEcdaaAlgorithm]</a> for details.
    /// </param>
    [JsonConstructor]
    public EcdaaTrustAnchorJSON(
        string x,
        string y,
        string c,
        string sx,
        string sy,
        string g1Curve)
    {
        X = x;
        Y = y;
        C = c;
        Sx = sx;
        Sy = sy;
        G1Curve = g1Curve;
    }

    /// <summary>
    ///     base64url encoding of the result of ECPoint2ToB of the ECPoint2 \(X = P_2^x\). See <a href="https://fidoalliance.org/specs/fido-v2.0-id-20180227/fido-ecdaa-algorithm-v2.0-id-20180227.html">[FIDOEcdaaAlgorithm]</a> for the definition of ECPoint2ToB.
    /// </summary>
    [JsonPropertyName("X")]
    [Required]
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public string X { get; }

    /// <summary>
    ///     base64url encoding of the result of ECPoint2ToB of the ECPoint2 \(Y = P_2^y\). See <a href="https://fidoalliance.org/specs/fido-v2.0-id-20180227/fido-ecdaa-algorithm-v2.0-id-20180227.html">[FIDOEcdaaAlgorithm]</a> for the definition of ECPoint2ToB.
    /// </summary>
    [JsonPropertyName("Y")]
    [Required]
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public string Y { get; }

    /// <summary>
    ///     base64url encoding of the result of BigNumberToB(\(c\)). See section "Issuer Specific ECDAA Parameters" in <a href="https://fidoalliance.org/specs/fido-v2.0-id-20180227/fido-ecdaa-algorithm-v2.0-id-20180227.html">[FIDOEcdaaAlgorithm]</a> for an explanation of \(c\). See
    ///     <a href="https://fidoalliance.org/specs/fido-v2.0-id-20180227/fido-ecdaa-algorithm-v2.0-id-20180227.html">[FIDOEcdaaAlgorithm]</a> for the definition of BigNumberToB.
    /// </summary>
    [JsonPropertyName("c")]
    [Required]
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public string C { get; }

    /// <summary>
    ///     base64url encoding of the result of BigNumberToB(\(sx\)). See section "Issuer Specific ECDAA Parameters" in <a href="https://fidoalliance.org/specs/fido-v2.0-id-20180227/fido-ecdaa-algorithm-v2.0-id-20180227.html">[FIDOEcdaaAlgorithm]</a> for an explanation of \(sx\). See
    ///     <a href="https://fidoalliance.org/specs/fido-v2.0-id-20180227/fido-ecdaa-algorithm-v2.0-id-20180227.html">[FIDOEcdaaAlgorithm]</a> for the definition of BigNumberToB.
    /// </summary>
    [JsonPropertyName("sx")]
    [Required]
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public string Sx { get; }

    /// <summary>
    ///     base64url encoding of the result of BigNumberToB(\(sy\)). See section "Issuer Specific ECDAA Parameters" in <a href="https://fidoalliance.org/specs/fido-v2.0-id-20180227/fido-ecdaa-algorithm-v2.0-id-20180227.html">[FIDOEcdaaAlgorithm]</a> for an explanation of \(sy\). See
    ///     <a href="https://fidoalliance.org/specs/fido-v2.0-id-20180227/fido-ecdaa-algorithm-v2.0-id-20180227.html">[FIDOEcdaaAlgorithm]</a> for the definition of BigNumberToB.
    /// </summary>
    [JsonPropertyName("sy")]
    [Required]
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public string Sy { get; }

    /// <summary>
    ///     Name of the Barreto-Naehrig elliptic curve for G1. "BN_P256", "BN_P638", "BN_ISOP256", and "BN_ISOP512" are supported. See section "Supported Curves for ECDAA" in
    ///     <a href="https://fidoalliance.org/specs/fido-v2.0-id-20180227/fido-ecdaa-algorithm-v2.0-id-20180227.html">[FIDOEcdaaAlgorithm]</a> for details.
    /// </summary>
    [JsonPropertyName("G1Curve")]
    [Required]
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public string G1Curve { get; }
}
