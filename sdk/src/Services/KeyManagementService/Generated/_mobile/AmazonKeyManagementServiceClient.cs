/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the kms-2014-11-01.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.KeyManagementService.Model;
using Amazon.KeyManagementService.Model.Internal.MarshallTransformations;
using Amazon.KeyManagementService.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.KeyManagementService
{
    /// <summary>
    /// Implementation for accessing KeyManagementService
    ///
    /// AWS Key Management Service 
    /// <para>
    /// AWS Key Management Service (AWS KMS) is an encryption and key management web service.
    /// This guide describes the AWS KMS operations that you can call programmatically. For
    /// general information about AWS KMS, see the <a href="http://docs.aws.amazon.com/kms/latest/developerguide/">AWS
    /// Key Management Service Developer Guide</a>.
    /// </para>
    ///  <note> 
    /// <para>
    /// AWS provides SDKs that consist of libraries and sample code for various programming
    /// languages and platforms (Java, Ruby, .Net, macOS, Android, etc.). The SDKs provide
    /// a convenient way to create programmatic access to AWS KMS and other AWS services.
    /// For example, the SDKs take care of tasks such as signing requests (see below), managing
    /// errors, and retrying requests automatically. For more information about the AWS SDKs,
    /// including how to download and install them, see <a href="http://aws.amazon.com/tools/">Tools
    /// for Amazon Web Services</a>.
    /// </para>
    ///  </note> 
    /// <para>
    /// We recommend that you use the AWS SDKs to make programmatic API calls to AWS KMS.
    /// </para>
    ///  
    /// <para>
    /// Clients must support TLS (Transport Layer Security) 1.0. We recommend TLS 1.2. Clients
    /// must also support cipher suites with Perfect Forward Secrecy (PFS) such as Ephemeral
    /// Diffie-Hellman (DHE) or Elliptic Curve Ephemeral Diffie-Hellman (ECDHE). Most modern
    /// systems such as Java 7 and later support these modes.
    /// </para>
    ///  
    /// <para>
    ///  <b>Signing Requests</b> 
    /// </para>
    ///  
    /// <para>
    /// Requests must be signed by using an access key ID and a secret access key. We strongly
    /// recommend that you <i>do not</i> use your AWS account (root) access key ID and secret
    /// key for everyday work with AWS KMS. Instead, use the access key ID and secret access
    /// key for an IAM user. You can also use the AWS Security Token Service to generate temporary
    /// security credentials that you can use to sign requests.
    /// </para>
    ///  
    /// <para>
    /// All AWS KMS operations require <a href="http://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
    /// Version 4</a>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Logging API Requests</b> 
    /// </para>
    ///  
    /// <para>
    /// AWS KMS supports AWS CloudTrail, a service that logs AWS API calls and related events
    /// for your AWS account and delivers them to an Amazon S3 bucket that you specify. By
    /// using the information collected by CloudTrail, you can determine what requests were
    /// made to AWS KMS, who made the request, when it was made, and so on. To learn more
    /// about CloudTrail, including how to turn it on and find your log files, see the <a
    /// href="http://docs.aws.amazon.com/awscloudtrail/latest/userguide/">AWS CloudTrail User
    /// Guide</a>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Additional Resources</b> 
    /// </para>
    ///  
    /// <para>
    /// For more information about credentials and request signing, see the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="http://docs.aws.amazon.com/general/latest/gr/aws-security-credentials.html">AWS
    /// Security Credentials</a> - This topic provides general information about the types
    /// of credentials used for accessing AWS.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp.html">Temporary
    /// Security Credentials</a> - This section of the <i>IAM User Guide</i> describes how
    /// to create and use temporary security credentials.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="http://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
    /// Version 4 Signing Process</a> - This set of topics walks you through the process of
    /// signing a request using an access key ID and a secret access key.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Commonly Used API Operations</b> 
    /// </para>
    ///  
    /// <para>
    /// Of the API operations discussed in this guide, the following will prove the most useful
    /// for most applications. You will likely perform operations other than these, such as
    /// creating keys and assigning policies, by using the console.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>Encrypt</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>Decrypt</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GenerateDataKey</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GenerateDataKeyWithoutPlaintext</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class AmazonKeyManagementServiceClient : AmazonServiceClient, IAmazonKeyManagementService
    {
        private static IServiceMetadata serviceMetadata = new AmazonKeyManagementServiceMetadata();
        
        #region Constructors

#if CORECLR
    
        /// <summary>
        /// Constructs AmazonKeyManagementServiceClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonKeyManagementServiceClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonKeyManagementServiceConfig()) { }

        /// <summary>
        /// Constructs AmazonKeyManagementServiceClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonKeyManagementServiceClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonKeyManagementServiceConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonKeyManagementServiceClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonKeyManagementServiceClient Configuration Object</param>
        public AmazonKeyManagementServiceClient(AmazonKeyManagementServiceConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

#endif

        /// <summary>
        /// Constructs AmazonKeyManagementServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonKeyManagementServiceClient(AWSCredentials credentials)
            : this(credentials, new AmazonKeyManagementServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonKeyManagementServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonKeyManagementServiceClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonKeyManagementServiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonKeyManagementServiceClient with AWS Credentials and an
        /// AmazonKeyManagementServiceClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonKeyManagementServiceClient Configuration Object</param>
        public AmazonKeyManagementServiceClient(AWSCredentials credentials, AmazonKeyManagementServiceConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonKeyManagementServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonKeyManagementServiceClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonKeyManagementServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonKeyManagementServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonKeyManagementServiceClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonKeyManagementServiceConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonKeyManagementServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonKeyManagementServiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonKeyManagementServiceClient Configuration Object</param>
        public AmazonKeyManagementServiceClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonKeyManagementServiceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonKeyManagementServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonKeyManagementServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonKeyManagementServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonKeyManagementServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonKeyManagementServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonKeyManagementServiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonKeyManagementServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonKeyManagementServiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonKeyManagementServiceClient Configuration Object</param>
        public AmazonKeyManagementServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonKeyManagementServiceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        } 

        /// <summary>
        /// Capture metadata for the service.
        /// </summary>
        protected override IServiceMetadata ServiceMetadata
        {
            get
            {
                return serviceMetadata;
            }
        }

        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion

        
        #region  CancelKeyDeletion

        internal virtual CancelKeyDeletionResponse CancelKeyDeletion(CancelKeyDeletionRequest request)
        {
            var marshaller = CancelKeyDeletionRequestMarshaller.Instance;
            var unmarshaller = CancelKeyDeletionResponseUnmarshaller.Instance;

            return Invoke<CancelKeyDeletionRequest,CancelKeyDeletionResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Cancels the deletion of a customer master key (CMK). When this operation is successful,
        /// the CMK is set to the <code>Disabled</code> state. To enable a CMK, use <a>EnableKey</a>.
        /// You cannot perform this operation on a CMK in a different AWS account.
        /// 
        ///  
        /// <para>
        /// For more information about scheduling and canceling deletion of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/deleting-keys.html">Deleting
        /// Customer Master Keys</a> in the <i>AWS Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The result of this operation varies with the key state of the CMK. For details, see
        /// <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="keyId">The unique identifier for the customer master key (CMK) for which to cancel deletion. Specify the key ID or the Amazon Resource Name (ARN) of the CMK. For example: <ul> <li> Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> </ul> To get the key ID and key ARN for a CMK, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelKeyDeletion service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/CancelKeyDeletion">REST API Reference for CancelKeyDeletion Operation</seealso>
        public virtual Task<CancelKeyDeletionResponse> CancelKeyDeletionAsync(string keyId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new CancelKeyDeletionRequest();
            request.KeyId = keyId;
            return CancelKeyDeletionAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CancelKeyDeletion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelKeyDeletion operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/CancelKeyDeletion">REST API Reference for CancelKeyDeletion Operation</seealso>
        public virtual Task<CancelKeyDeletionResponse> CancelKeyDeletionAsync(CancelKeyDeletionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CancelKeyDeletionRequestMarshaller.Instance;
            var unmarshaller = CancelKeyDeletionResponseUnmarshaller.Instance;

            return InvokeAsync<CancelKeyDeletionRequest,CancelKeyDeletionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateAlias

        internal virtual CreateAliasResponse CreateAlias(CreateAliasRequest request)
        {
            var marshaller = CreateAliasRequestMarshaller.Instance;
            var unmarshaller = CreateAliasResponseUnmarshaller.Instance;

            return Invoke<CreateAliasRequest,CreateAliasResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Creates a display name for a customer-managed customer master key (CMK). You can use
        /// an alias to identify a CMK in selected operations, such as <a>Encrypt</a> and <a>GenerateDataKey</a>.
        /// 
        /// 
        ///  
        /// <para>
        /// Each CMK can have multiple aliases, but each alias points to only one CMK. The alias
        /// name must be unique in the AWS account and region. To simplify code that runs in multiple
        /// regions, use the same alias name, but point it to a different CMK in each region.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Because an alias is not a property of a CMK, you can delete and change the aliases
        /// of a CMK without affecting the CMK. Also, aliases do not appear in the response from
        /// the <a>DescribeKey</a> operation. To get the aliases of all CMKs, use the <a>ListAliases</a>
        /// operation.
        /// </para>
        ///  
        /// <para>
        /// The alias name can contain only alphanumeric characters, forward slashes (/), underscores
        /// (_), and dashes (-). Alias names cannot begin with <b>aws/</b>. That alias name prefix
        /// is reserved for AWS managed CMKs.
        /// </para>
        ///  
        /// <para>
        /// The alias and the CMK it is mapped to must be in the same AWS account and the same
        /// region. You cannot perform this operation on an alias in a different AWS account.
        /// </para>
        ///  
        /// <para>
        /// To map an existing alias to a different CMK, call <a>UpdateAlias</a>.
        /// </para>
        ///  
        /// <para>
        /// The result of this operation varies with the key state of the CMK. For details, see
        /// <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="aliasName">Specifies the alias name. This value must begin with <code>alias/</code> followed by the alias name, such as <code>alias/ExampleAlias</code>. The alias name cannot begin with <code>aws/</code>. The <code>alias/aws/</code> prefix is reserved for AWS managed CMKs.</param>
        /// <param name="targetKeyId">Identifies the CMK for which you are creating the alias. This value cannot be an alias. Specify the key ID or the Amazon Resource Name (ARN) of the CMK. For example: <ul> <li> Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> </ul> To get the key ID and key ARN for a CMK, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAlias service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.AlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidAliasNameException">
        /// The request was rejected because the specified alias name is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.LimitExceededException">
        /// The request was rejected because a limit was exceeded. For more information, see <a
        /// href="http://docs.aws.amazon.com/kms/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS Key Management Service Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/CreateAlias">REST API Reference for CreateAlias Operation</seealso>
        public virtual Task<CreateAliasResponse> CreateAliasAsync(string aliasName, string targetKeyId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new CreateAliasRequest();
            request.AliasName = aliasName;
            request.TargetKeyId = targetKeyId;
            return CreateAliasAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAlias operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/CreateAlias">REST API Reference for CreateAlias Operation</seealso>
        public virtual Task<CreateAliasResponse> CreateAliasAsync(CreateAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateAliasRequestMarshaller.Instance;
            var unmarshaller = CreateAliasResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAliasRequest,CreateAliasResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateGrant

        internal virtual CreateGrantResponse CreateGrant(CreateGrantRequest request)
        {
            var marshaller = CreateGrantRequestMarshaller.Instance;
            var unmarshaller = CreateGrantResponseUnmarshaller.Instance;

            return Invoke<CreateGrantRequest,CreateGrantResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateGrant operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateGrant operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/CreateGrant">REST API Reference for CreateGrant Operation</seealso>
        public virtual Task<CreateGrantResponse> CreateGrantAsync(CreateGrantRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateGrantRequestMarshaller.Instance;
            var unmarshaller = CreateGrantResponseUnmarshaller.Instance;

            return InvokeAsync<CreateGrantRequest,CreateGrantResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateKey

        internal virtual CreateKeyResponse CreateKey(CreateKeyRequest request)
        {
            var marshaller = CreateKeyRequestMarshaller.Instance;
            var unmarshaller = CreateKeyResponseUnmarshaller.Instance;

            return Invoke<CreateKeyRequest,CreateKeyResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateKey operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/CreateKey">REST API Reference for CreateKey Operation</seealso>
        public virtual Task<CreateKeyResponse> CreateKeyAsync(CreateKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateKeyRequestMarshaller.Instance;
            var unmarshaller = CreateKeyResponseUnmarshaller.Instance;

            return InvokeAsync<CreateKeyRequest,CreateKeyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  Decrypt

        internal virtual DecryptResponse Decrypt(DecryptRequest request)
        {
            var marshaller = DecryptRequestMarshaller.Instance;
            var unmarshaller = DecryptResponseUnmarshaller.Instance;

            return Invoke<DecryptRequest,DecryptResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the Decrypt operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the Decrypt operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/Decrypt">REST API Reference for Decrypt Operation</seealso>
        public virtual Task<DecryptResponse> DecryptAsync(DecryptRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DecryptRequestMarshaller.Instance;
            var unmarshaller = DecryptResponseUnmarshaller.Instance;

            return InvokeAsync<DecryptRequest,DecryptResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteAlias

        internal virtual DeleteAliasResponse DeleteAlias(DeleteAliasRequest request)
        {
            var marshaller = DeleteAliasRequestMarshaller.Instance;
            var unmarshaller = DeleteAliasResponseUnmarshaller.Instance;

            return Invoke<DeleteAliasRequest,DeleteAliasResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Deletes the specified alias. You cannot perform this operation on an alias in a different
        /// AWS account. 
        /// 
        ///  
        /// <para>
        /// Because an alias is not a property of a CMK, you can delete and change the aliases
        /// of a CMK without affecting the CMK. Also, aliases do not appear in the response from
        /// the <a>DescribeKey</a> operation. To get the aliases of all CMKs, use the <a>ListAliases</a>
        /// operation. 
        /// </para>
        ///  
        /// <para>
        /// Each CMK can have multiple aliases. To change the alias of a CMK, use <a>DeleteAlias</a>
        /// to delete the current alias and <a>CreateAlias</a> to create a new alias. To associate
        /// an existing alias with a different customer master key (CMK), call <a>UpdateAlias</a>.
        /// </para>
        /// </summary>
        /// <param name="aliasName">The alias to be deleted. The name must start with the word "alias" followed by a forward slash (alias/). Aliases that begin with "alias/aws" are reserved.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAlias service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DeleteAlias">REST API Reference for DeleteAlias Operation</seealso>
        public virtual Task<DeleteAliasResponse> DeleteAliasAsync(string aliasName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DeleteAliasRequest();
            request.AliasName = aliasName;
            return DeleteAliasAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAlias operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DeleteAlias">REST API Reference for DeleteAlias Operation</seealso>
        public virtual Task<DeleteAliasResponse> DeleteAliasAsync(DeleteAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteAliasRequestMarshaller.Instance;
            var unmarshaller = DeleteAliasResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAliasRequest,DeleteAliasResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteImportedKeyMaterial

        internal virtual DeleteImportedKeyMaterialResponse DeleteImportedKeyMaterial(DeleteImportedKeyMaterialRequest request)
        {
            var marshaller = DeleteImportedKeyMaterialRequestMarshaller.Instance;
            var unmarshaller = DeleteImportedKeyMaterialResponseUnmarshaller.Instance;

            return Invoke<DeleteImportedKeyMaterialRequest,DeleteImportedKeyMaterialResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteImportedKeyMaterial operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteImportedKeyMaterial operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DeleteImportedKeyMaterial">REST API Reference for DeleteImportedKeyMaterial Operation</seealso>
        public virtual Task<DeleteImportedKeyMaterialResponse> DeleteImportedKeyMaterialAsync(DeleteImportedKeyMaterialRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteImportedKeyMaterialRequestMarshaller.Instance;
            var unmarshaller = DeleteImportedKeyMaterialResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteImportedKeyMaterialRequest,DeleteImportedKeyMaterialResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeKey

        internal virtual DescribeKeyResponse DescribeKey(DescribeKeyRequest request)
        {
            var marshaller = DescribeKeyRequestMarshaller.Instance;
            var unmarshaller = DescribeKeyResponseUnmarshaller.Instance;

            return Invoke<DescribeKeyRequest,DescribeKeyResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Provides detailed information about the specified customer master key (CMK).
        /// 
        ///  
        /// <para>
        /// You can use <code>DescribeKey</code> on a predefined AWS alias, that is, an AWS alias
        /// with no key ID. When you do, AWS KMS associates the alias with an <a href="http://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#master_keys">AWS
        /// managed CMK</a> and returns its <code>KeyId</code> and <code>Arn</code> in the response.
        /// </para>
        ///  
        /// <para>
        /// To perform this operation on a CMK in a different AWS account, specify the key ARN
        /// or alias ARN in the value of the KeyId parameter.
        /// </para>
        /// </summary>
        /// <param name="keyId">Describes the specified customer master key (CMK).  If you specify a predefined AWS alias (an AWS alias with no key ID), KMS associates the alias with an <a href="http://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#master_keys">AWS managed CMK</a> and returns its <code>KeyId</code> and <code>Arn</code> in the response. To specify a CMK, use its key ID, Amazon Resource Name (ARN), alias name, or alias ARN. When using an alias name, prefix it with <code>"alias/"</code>. To specify a CMK in a different AWS account, you must use the key ARN or alias ARN. For example: <ul> <li> Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Alias name: <code>alias/ExampleAlias</code>  </li> <li> Alias ARN: <code>arn:aws:kms:us-east-2:111122223333:alias/ExampleAlias</code>  </li> </ul> To get the key ID and key ARN for a CMK, use <a>ListKeys</a> or <a>DescribeKey</a>. To get the alias name and alias ARN, use <a>ListAliases</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeKey service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DescribeKey">REST API Reference for DescribeKey Operation</seealso>
        public virtual Task<DescribeKeyResponse> DescribeKeyAsync(string keyId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DescribeKeyRequest();
            request.KeyId = keyId;
            return DescribeKeyAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeKey operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DescribeKey">REST API Reference for DescribeKey Operation</seealso>
        public virtual Task<DescribeKeyResponse> DescribeKeyAsync(DescribeKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeKeyRequestMarshaller.Instance;
            var unmarshaller = DescribeKeyResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeKeyRequest,DescribeKeyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DisableKey

        internal virtual DisableKeyResponse DisableKey(DisableKeyRequest request)
        {
            var marshaller = DisableKeyRequestMarshaller.Instance;
            var unmarshaller = DisableKeyResponseUnmarshaller.Instance;

            return Invoke<DisableKeyRequest,DisableKeyResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Sets the state of a customer master key (CMK) to disabled, thereby preventing its
        /// use for cryptographic operations. You cannot perform this operation on a CMK in a
        /// different AWS account.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects the Use of a Customer Master Key</a> in the <i>AWS Key Management
        /// Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The result of this operation varies with the key state of the CMK. For details, see
        /// <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="keyId">A unique identifier for the customer master key (CMK). Specify the key ID or the Amazon Resource Name (ARN) of the CMK. For example: <ul> <li> Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> </ul> To get the key ID and key ARN for a CMK, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisableKey service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DisableKey">REST API Reference for DisableKey Operation</seealso>
        public virtual Task<DisableKeyResponse> DisableKeyAsync(string keyId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DisableKeyRequest();
            request.KeyId = keyId;
            return DisableKeyAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DisableKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableKey operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DisableKey">REST API Reference for DisableKey Operation</seealso>
        public virtual Task<DisableKeyResponse> DisableKeyAsync(DisableKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DisableKeyRequestMarshaller.Instance;
            var unmarshaller = DisableKeyResponseUnmarshaller.Instance;

            return InvokeAsync<DisableKeyRequest,DisableKeyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DisableKeyRotation

        internal virtual DisableKeyRotationResponse DisableKeyRotation(DisableKeyRotationRequest request)
        {
            var marshaller = DisableKeyRotationRequestMarshaller.Instance;
            var unmarshaller = DisableKeyRotationResponseUnmarshaller.Instance;

            return Invoke<DisableKeyRotationRequest,DisableKeyRotationResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Disables <a href="http://docs.aws.amazon.com/kms/latest/developerguide/rotate-keys.html">automatic
        /// rotation of the key material</a> for the specified customer master key (CMK). You
        /// cannot perform this operation on a CMK in a different AWS account.
        /// 
        ///  
        /// <para>
        /// The result of this operation varies with the key state of the CMK. For details, see
        /// <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="keyId">A unique identifier for the customer master key (CMK). Specify the key ID or the Amazon Resource Name (ARN) of the CMK. For example: <ul> <li> Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> </ul> To get the key ID and key ARN for a CMK, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisableKeyRotation service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified CMK is not enabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DisableKeyRotation">REST API Reference for DisableKeyRotation Operation</seealso>
        public virtual Task<DisableKeyRotationResponse> DisableKeyRotationAsync(string keyId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DisableKeyRotationRequest();
            request.KeyId = keyId;
            return DisableKeyRotationAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DisableKeyRotation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableKeyRotation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DisableKeyRotation">REST API Reference for DisableKeyRotation Operation</seealso>
        public virtual Task<DisableKeyRotationResponse> DisableKeyRotationAsync(DisableKeyRotationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DisableKeyRotationRequestMarshaller.Instance;
            var unmarshaller = DisableKeyRotationResponseUnmarshaller.Instance;

            return InvokeAsync<DisableKeyRotationRequest,DisableKeyRotationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  EnableKey

        internal virtual EnableKeyResponse EnableKey(EnableKeyRequest request)
        {
            var marshaller = EnableKeyRequestMarshaller.Instance;
            var unmarshaller = EnableKeyResponseUnmarshaller.Instance;

            return Invoke<EnableKeyRequest,EnableKeyResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Sets the state of a customer master key (CMK) to enabled, thereby permitting its use
        /// for cryptographic operations. You cannot perform this operation on a CMK in a different
        /// AWS account.
        /// 
        ///  
        /// <para>
        /// The result of this operation varies with the key state of the CMK. For details, see
        /// <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="keyId">A unique identifier for the customer master key (CMK). Specify the key ID or the Amazon Resource Name (ARN) of the CMK. For example: <ul> <li> Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> </ul> To get the key ID and key ARN for a CMK, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableKey service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.LimitExceededException">
        /// The request was rejected because a limit was exceeded. For more information, see <a
        /// href="http://docs.aws.amazon.com/kms/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS Key Management Service Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/EnableKey">REST API Reference for EnableKey Operation</seealso>
        public virtual Task<EnableKeyResponse> EnableKeyAsync(string keyId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new EnableKeyRequest();
            request.KeyId = keyId;
            return EnableKeyAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the EnableKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableKey operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/EnableKey">REST API Reference for EnableKey Operation</seealso>
        public virtual Task<EnableKeyResponse> EnableKeyAsync(EnableKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = EnableKeyRequestMarshaller.Instance;
            var unmarshaller = EnableKeyResponseUnmarshaller.Instance;

            return InvokeAsync<EnableKeyRequest,EnableKeyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  EnableKeyRotation

        internal virtual EnableKeyRotationResponse EnableKeyRotation(EnableKeyRotationRequest request)
        {
            var marshaller = EnableKeyRotationRequestMarshaller.Instance;
            var unmarshaller = EnableKeyRotationResponseUnmarshaller.Instance;

            return Invoke<EnableKeyRotationRequest,EnableKeyRotationResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Enables <a href="http://docs.aws.amazon.com/kms/latest/developerguide/rotate-keys.html">automatic
        /// rotation of the key material</a> for the specified customer master key (CMK). You
        /// cannot perform this operation on a CMK in a different AWS account.
        /// 
        ///  
        /// <para>
        /// The result of this operation varies with the key state of the CMK. For details, see
        /// <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="keyId">A unique identifier for the customer master key (CMK). Specify the key ID or the Amazon Resource Name (ARN) of the CMK. For example: <ul> <li> Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> </ul> To get the key ID and key ARN for a CMK, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableKeyRotation service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified CMK is not enabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/EnableKeyRotation">REST API Reference for EnableKeyRotation Operation</seealso>
        public virtual Task<EnableKeyRotationResponse> EnableKeyRotationAsync(string keyId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new EnableKeyRotationRequest();
            request.KeyId = keyId;
            return EnableKeyRotationAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the EnableKeyRotation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableKeyRotation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/EnableKeyRotation">REST API Reference for EnableKeyRotation Operation</seealso>
        public virtual Task<EnableKeyRotationResponse> EnableKeyRotationAsync(EnableKeyRotationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = EnableKeyRotationRequestMarshaller.Instance;
            var unmarshaller = EnableKeyRotationResponseUnmarshaller.Instance;

            return InvokeAsync<EnableKeyRotationRequest,EnableKeyRotationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  Encrypt

        internal virtual EncryptResponse Encrypt(EncryptRequest request)
        {
            var marshaller = EncryptRequestMarshaller.Instance;
            var unmarshaller = EncryptResponseUnmarshaller.Instance;

            return Invoke<EncryptRequest,EncryptResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the Encrypt operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the Encrypt operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/Encrypt">REST API Reference for Encrypt Operation</seealso>
        public virtual Task<EncryptResponse> EncryptAsync(EncryptRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = EncryptRequestMarshaller.Instance;
            var unmarshaller = EncryptResponseUnmarshaller.Instance;

            return InvokeAsync<EncryptRequest,EncryptResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GenerateDataKey

        internal virtual GenerateDataKeyResponse GenerateDataKey(GenerateDataKeyRequest request)
        {
            var marshaller = GenerateDataKeyRequestMarshaller.Instance;
            var unmarshaller = GenerateDataKeyResponseUnmarshaller.Instance;

            return Invoke<GenerateDataKeyRequest,GenerateDataKeyResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GenerateDataKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GenerateDataKey operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/GenerateDataKey">REST API Reference for GenerateDataKey Operation</seealso>
        public virtual Task<GenerateDataKeyResponse> GenerateDataKeyAsync(GenerateDataKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GenerateDataKeyRequestMarshaller.Instance;
            var unmarshaller = GenerateDataKeyResponseUnmarshaller.Instance;

            return InvokeAsync<GenerateDataKeyRequest,GenerateDataKeyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GenerateDataKeyWithoutPlaintext

        internal virtual GenerateDataKeyWithoutPlaintextResponse GenerateDataKeyWithoutPlaintext(GenerateDataKeyWithoutPlaintextRequest request)
        {
            var marshaller = GenerateDataKeyWithoutPlaintextRequestMarshaller.Instance;
            var unmarshaller = GenerateDataKeyWithoutPlaintextResponseUnmarshaller.Instance;

            return Invoke<GenerateDataKeyWithoutPlaintextRequest,GenerateDataKeyWithoutPlaintextResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GenerateDataKeyWithoutPlaintext operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GenerateDataKeyWithoutPlaintext operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/GenerateDataKeyWithoutPlaintext">REST API Reference for GenerateDataKeyWithoutPlaintext Operation</seealso>
        public virtual Task<GenerateDataKeyWithoutPlaintextResponse> GenerateDataKeyWithoutPlaintextAsync(GenerateDataKeyWithoutPlaintextRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GenerateDataKeyWithoutPlaintextRequestMarshaller.Instance;
            var unmarshaller = GenerateDataKeyWithoutPlaintextResponseUnmarshaller.Instance;

            return InvokeAsync<GenerateDataKeyWithoutPlaintextRequest,GenerateDataKeyWithoutPlaintextResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GenerateRandom

        internal virtual GenerateRandomResponse GenerateRandom(GenerateRandomRequest request)
        {
            var marshaller = GenerateRandomRequestMarshaller.Instance;
            var unmarshaller = GenerateRandomResponseUnmarshaller.Instance;

            return Invoke<GenerateRandomRequest,GenerateRandomResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Returns a random byte string that is cryptographically secure.
        /// 
        ///  
        /// <para>
        /// For more information about entropy and random number generation, see the <a href="https://d0.awsstatic.com/whitepapers/KMS-Cryptographic-Details.pdf">AWS
        /// Key Management Service Cryptographic Details</a> whitepaper.
        /// </para>
        /// </summary>
        /// <param name="numberOfBytes">The length of the byte string.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GenerateRandom service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/GenerateRandom">REST API Reference for GenerateRandom Operation</seealso>
        public virtual Task<GenerateRandomResponse> GenerateRandomAsync(int numberOfBytes, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GenerateRandomRequest();
            request.NumberOfBytes = numberOfBytes;
            return GenerateRandomAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GenerateRandom operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GenerateRandom operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/GenerateRandom">REST API Reference for GenerateRandom Operation</seealso>
        public virtual Task<GenerateRandomResponse> GenerateRandomAsync(GenerateRandomRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GenerateRandomRequestMarshaller.Instance;
            var unmarshaller = GenerateRandomResponseUnmarshaller.Instance;

            return InvokeAsync<GenerateRandomRequest,GenerateRandomResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetKeyPolicy

        internal virtual GetKeyPolicyResponse GetKeyPolicy(GetKeyPolicyRequest request)
        {
            var marshaller = GetKeyPolicyRequestMarshaller.Instance;
            var unmarshaller = GetKeyPolicyResponseUnmarshaller.Instance;

            return Invoke<GetKeyPolicyRequest,GetKeyPolicyResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Gets a key policy attached to the specified customer master key (CMK). You cannot
        /// perform this operation on a CMK in a different AWS account.
        /// </summary>
        /// <param name="keyId">A unique identifier for the customer master key (CMK). Specify the key ID or the Amazon Resource Name (ARN) of the CMK. For example: <ul> <li> Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> </ul> To get the key ID and key ARN for a CMK, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// <param name="policyName">Specifies the name of the key policy. The only valid name is <code>default</code>. To get the names of key policies, use <a>ListKeyPolicies</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetKeyPolicy service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/GetKeyPolicy">REST API Reference for GetKeyPolicy Operation</seealso>
        public virtual Task<GetKeyPolicyResponse> GetKeyPolicyAsync(string keyId, string policyName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetKeyPolicyRequest();
            request.KeyId = keyId;
            request.PolicyName = policyName;
            return GetKeyPolicyAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetKeyPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetKeyPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/GetKeyPolicy">REST API Reference for GetKeyPolicy Operation</seealso>
        public virtual Task<GetKeyPolicyResponse> GetKeyPolicyAsync(GetKeyPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetKeyPolicyRequestMarshaller.Instance;
            var unmarshaller = GetKeyPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<GetKeyPolicyRequest,GetKeyPolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetKeyRotationStatus

        internal virtual GetKeyRotationStatusResponse GetKeyRotationStatus(GetKeyRotationStatusRequest request)
        {
            var marshaller = GetKeyRotationStatusRequestMarshaller.Instance;
            var unmarshaller = GetKeyRotationStatusResponseUnmarshaller.Instance;

            return Invoke<GetKeyRotationStatusRequest,GetKeyRotationStatusResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Gets a Boolean value that indicates whether <a href="http://docs.aws.amazon.com/kms/latest/developerguide/rotate-keys.html">automatic
        /// rotation of the key material</a> is enabled for the specified customer master key
        /// (CMK).
        /// 
        ///  
        /// <para>
        /// The result of this operation varies with the key state of the CMK. For details, see
        /// <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Disabled: The key rotation status does not change when you disable a CMK. However,
        /// while the CMK is disabled, AWS KMS does not rotate the backing key.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Pending deletion: While a CMK is pending deletion, its key rotation status is <code>false</code>
        /// and AWS KMS does not rotate the backing key. If you cancel the deletion, the original
        /// key rotation status is restored.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To perform this operation on a CMK in a different AWS account, specify the key ARN
        /// in the value of the <code>KeyId</code> parameter.
        /// </para>
        /// </summary>
        /// <param name="keyId">A unique identifier for the customer master key (CMK). Specify the key ID or the Amazon Resource Name (ARN) of the CMK. To specify a CMK in a different AWS account, you must use the key ARN. For example: <ul> <li> Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> </ul> To get the key ID and key ARN for a CMK, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetKeyRotationStatus service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/GetKeyRotationStatus">REST API Reference for GetKeyRotationStatus Operation</seealso>
        public virtual Task<GetKeyRotationStatusResponse> GetKeyRotationStatusAsync(string keyId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetKeyRotationStatusRequest();
            request.KeyId = keyId;
            return GetKeyRotationStatusAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetKeyRotationStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetKeyRotationStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/GetKeyRotationStatus">REST API Reference for GetKeyRotationStatus Operation</seealso>
        public virtual Task<GetKeyRotationStatusResponse> GetKeyRotationStatusAsync(GetKeyRotationStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetKeyRotationStatusRequestMarshaller.Instance;
            var unmarshaller = GetKeyRotationStatusResponseUnmarshaller.Instance;

            return InvokeAsync<GetKeyRotationStatusRequest,GetKeyRotationStatusResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetParametersForImport

        internal virtual GetParametersForImportResponse GetParametersForImport(GetParametersForImportRequest request)
        {
            var marshaller = GetParametersForImportRequestMarshaller.Instance;
            var unmarshaller = GetParametersForImportResponseUnmarshaller.Instance;

            return Invoke<GetParametersForImportRequest,GetParametersForImportResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetParametersForImport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetParametersForImport operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/GetParametersForImport">REST API Reference for GetParametersForImport Operation</seealso>
        public virtual Task<GetParametersForImportResponse> GetParametersForImportAsync(GetParametersForImportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetParametersForImportRequestMarshaller.Instance;
            var unmarshaller = GetParametersForImportResponseUnmarshaller.Instance;

            return InvokeAsync<GetParametersForImportRequest,GetParametersForImportResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ImportKeyMaterial

        internal virtual ImportKeyMaterialResponse ImportKeyMaterial(ImportKeyMaterialRequest request)
        {
            var marshaller = ImportKeyMaterialRequestMarshaller.Instance;
            var unmarshaller = ImportKeyMaterialResponseUnmarshaller.Instance;

            return Invoke<ImportKeyMaterialRequest,ImportKeyMaterialResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ImportKeyMaterial operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportKeyMaterial operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ImportKeyMaterial">REST API Reference for ImportKeyMaterial Operation</seealso>
        public virtual Task<ImportKeyMaterialResponse> ImportKeyMaterialAsync(ImportKeyMaterialRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ImportKeyMaterialRequestMarshaller.Instance;
            var unmarshaller = ImportKeyMaterialResponseUnmarshaller.Instance;

            return InvokeAsync<ImportKeyMaterialRequest,ImportKeyMaterialResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListAliases

        internal virtual ListAliasesResponse ListAliases(ListAliasesRequest request)
        {
            var marshaller = ListAliasesRequestMarshaller.Instance;
            var unmarshaller = ListAliasesResponseUnmarshaller.Instance;

            return Invoke<ListAliasesRequest,ListAliasesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListAliases operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAliases operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ListAliases">REST API Reference for ListAliases Operation</seealso>
        public virtual Task<ListAliasesResponse> ListAliasesAsync(ListAliasesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListAliasesRequestMarshaller.Instance;
            var unmarshaller = ListAliasesResponseUnmarshaller.Instance;

            return InvokeAsync<ListAliasesRequest,ListAliasesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListGrants

        internal virtual ListGrantsResponse ListGrants(ListGrantsRequest request)
        {
            var marshaller = ListGrantsRequestMarshaller.Instance;
            var unmarshaller = ListGrantsResponseUnmarshaller.Instance;

            return Invoke<ListGrantsRequest,ListGrantsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListGrants operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGrants operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ListGrants">REST API Reference for ListGrants Operation</seealso>
        public virtual Task<ListGrantsResponse> ListGrantsAsync(ListGrantsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListGrantsRequestMarshaller.Instance;
            var unmarshaller = ListGrantsResponseUnmarshaller.Instance;

            return InvokeAsync<ListGrantsRequest,ListGrantsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListKeyPolicies

        internal virtual ListKeyPoliciesResponse ListKeyPolicies(ListKeyPoliciesRequest request)
        {
            var marshaller = ListKeyPoliciesRequestMarshaller.Instance;
            var unmarshaller = ListKeyPoliciesResponseUnmarshaller.Instance;

            return Invoke<ListKeyPoliciesRequest,ListKeyPoliciesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListKeyPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListKeyPolicies operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ListKeyPolicies">REST API Reference for ListKeyPolicies Operation</seealso>
        public virtual Task<ListKeyPoliciesResponse> ListKeyPoliciesAsync(ListKeyPoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListKeyPoliciesRequestMarshaller.Instance;
            var unmarshaller = ListKeyPoliciesResponseUnmarshaller.Instance;

            return InvokeAsync<ListKeyPoliciesRequest,ListKeyPoliciesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListKeys

        internal virtual ListKeysResponse ListKeys(ListKeysRequest request)
        {
            var marshaller = ListKeysRequestMarshaller.Instance;
            var unmarshaller = ListKeysResponseUnmarshaller.Instance;

            return Invoke<ListKeysRequest,ListKeysResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListKeys operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListKeys operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ListKeys">REST API Reference for ListKeys Operation</seealso>
        public virtual Task<ListKeysResponse> ListKeysAsync(ListKeysRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListKeysRequestMarshaller.Instance;
            var unmarshaller = ListKeysResponseUnmarshaller.Instance;

            return InvokeAsync<ListKeysRequest,ListKeysResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListResourceTags

        internal virtual ListResourceTagsResponse ListResourceTags(ListResourceTagsRequest request)
        {
            var marshaller = ListResourceTagsRequestMarshaller.Instance;
            var unmarshaller = ListResourceTagsResponseUnmarshaller.Instance;

            return Invoke<ListResourceTagsRequest,ListResourceTagsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListResourceTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListResourceTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ListResourceTags">REST API Reference for ListResourceTags Operation</seealso>
        public virtual Task<ListResourceTagsResponse> ListResourceTagsAsync(ListResourceTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListResourceTagsRequestMarshaller.Instance;
            var unmarshaller = ListResourceTagsResponseUnmarshaller.Instance;

            return InvokeAsync<ListResourceTagsRequest,ListResourceTagsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListRetirableGrants

        internal virtual ListRetirableGrantsResponse ListRetirableGrants(ListRetirableGrantsRequest request)
        {
            var marshaller = ListRetirableGrantsRequestMarshaller.Instance;
            var unmarshaller = ListRetirableGrantsResponseUnmarshaller.Instance;

            return Invoke<ListRetirableGrantsRequest,ListRetirableGrantsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Returns a list of all grants for which the grant's <code>RetiringPrincipal</code>
        /// matches the one specified.
        /// 
        ///  
        /// <para>
        /// A typical use is to list all grants that you are able to retire. To retire a grant,
        /// use <a>RetireGrant</a>.
        /// </para>
        /// </summary>
        /// <param name="retiringPrincipal">The retiring principal for which to list grants. To specify the retiring principal, use the <a href="http://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon Resource Name (ARN)</a> of an AWS principal. Valid AWS principals include AWS accounts (root), IAM users, federated users, and assumed role users. For examples of the ARN syntax for specifying a principal, see <a href="http://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html#arn-syntax-iam">AWS Identity and Access Management (IAM)</a> in the Example ARNs section of the <i>Amazon Web Services General Reference</i>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRetirableGrants service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidMarkerException">
        /// The request was rejected because the marker that specifies where pagination should
        /// next begin is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ListRetirableGrants">REST API Reference for ListRetirableGrants Operation</seealso>
        public virtual Task<ListRetirableGrantsResponse> ListRetirableGrantsAsync(string retiringPrincipal, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new ListRetirableGrantsRequest();
            request.RetiringPrincipal = retiringPrincipal;
            return ListRetirableGrantsAsync(request, cancellationToken);
        }


        /// <summary>
        /// Returns a list of all grants for which the grant's <code>RetiringPrincipal</code>
        /// matches the one specified.
        /// 
        ///  
        /// <para>
        /// A typical use is to list all grants that you are able to retire. To retire a grant,
        /// use <a>RetireGrant</a>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRetirableGrants service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidMarkerException">
        /// The request was rejected because the marker that specifies where pagination should
        /// next begin is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ListRetirableGrants">REST API Reference for ListRetirableGrants Operation</seealso>
        public virtual Task<ListRetirableGrantsResponse> ListRetirableGrantsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new ListRetirableGrantsRequest();
            return ListRetirableGrantsAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListRetirableGrants operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRetirableGrants operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ListRetirableGrants">REST API Reference for ListRetirableGrants Operation</seealso>
        public virtual Task<ListRetirableGrantsResponse> ListRetirableGrantsAsync(ListRetirableGrantsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListRetirableGrantsRequestMarshaller.Instance;
            var unmarshaller = ListRetirableGrantsResponseUnmarshaller.Instance;

            return InvokeAsync<ListRetirableGrantsRequest,ListRetirableGrantsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutKeyPolicy

        internal virtual PutKeyPolicyResponse PutKeyPolicy(PutKeyPolicyRequest request)
        {
            var marshaller = PutKeyPolicyRequestMarshaller.Instance;
            var unmarshaller = PutKeyPolicyResponseUnmarshaller.Instance;

            return Invoke<PutKeyPolicyRequest,PutKeyPolicyResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Attaches a key policy to the specified customer master key (CMK). You cannot perform
        /// this operation on a CMK in a different AWS account.
        /// 
        ///  
        /// <para>
        /// For more information about key policies, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-policies.html">Key
        /// Policies</a> in the <i>AWS Key Management Service Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="keyId">A unique identifier for the customer master key (CMK). Specify the key ID or the Amazon Resource Name (ARN) of the CMK. For example: <ul> <li> Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> </ul> To get the key ID and key ARN for a CMK, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// <param name="policy">The key policy to attach to the CMK. The key policy must meet the following criteria: <ul> <li> If you don't set <code>BypassPolicyLockoutSafetyCheck</code> to true, the key policy must allow the principal that is making the <code>PutKeyPolicy</code> request to make a subsequent <code>PutKeyPolicy</code> request on the CMK. This reduces the risk that the CMK becomes unmanageable. For more information, refer to the scenario in the <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-policies.html#key-policy-default-allow-root-enable-iam">Default Key Policy</a> section of the <i>AWS Key Management Service Developer Guide</i>. </li> <li> Each statement in the key policy must contain one or more principals. The principals in the key policy must exist and be visible to AWS KMS. When you create a new AWS principal (for example, an IAM user or role), you might need to enforce a delay before including the new principal in a key policy. The reason for this is that the new principal might not be immediately visible to AWS KMS. For more information, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/troubleshoot_general.html#troubleshoot_general_eventual-consistency">Changes that I make are not always immediately visible</a> in the <i>AWS Identity and Access Management User Guide</i>. </li> </ul> The key policy size limit is 32 kilobytes (32768 bytes).</param>
        /// <param name="policyName">The name of the key policy. The only valid value is <code>default</code>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutKeyPolicy service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.LimitExceededException">
        /// The request was rejected because a limit was exceeded. For more information, see <a
        /// href="http://docs.aws.amazon.com/kms/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS Key Management Service Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.MalformedPolicyDocumentException">
        /// The request was rejected because the specified policy is not syntactically or semantically
        /// correct.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/PutKeyPolicy">REST API Reference for PutKeyPolicy Operation</seealso>
        public virtual Task<PutKeyPolicyResponse> PutKeyPolicyAsync(string keyId, string policy, string policyName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new PutKeyPolicyRequest();
            request.KeyId = keyId;
            request.Policy = policy;
            request.PolicyName = policyName;
            return PutKeyPolicyAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutKeyPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutKeyPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/PutKeyPolicy">REST API Reference for PutKeyPolicy Operation</seealso>
        public virtual Task<PutKeyPolicyResponse> PutKeyPolicyAsync(PutKeyPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = PutKeyPolicyRequestMarshaller.Instance;
            var unmarshaller = PutKeyPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<PutKeyPolicyRequest,PutKeyPolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ReEncrypt

        internal virtual ReEncryptResponse ReEncrypt(ReEncryptRequest request)
        {
            var marshaller = ReEncryptRequestMarshaller.Instance;
            var unmarshaller = ReEncryptResponseUnmarshaller.Instance;

            return Invoke<ReEncryptRequest,ReEncryptResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ReEncrypt operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReEncrypt operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ReEncrypt">REST API Reference for ReEncrypt Operation</seealso>
        public virtual Task<ReEncryptResponse> ReEncryptAsync(ReEncryptRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ReEncryptRequestMarshaller.Instance;
            var unmarshaller = ReEncryptResponseUnmarshaller.Instance;

            return InvokeAsync<ReEncryptRequest,ReEncryptResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RetireGrant

        internal virtual RetireGrantResponse RetireGrant(RetireGrantRequest request)
        {
            var marshaller = RetireGrantRequestMarshaller.Instance;
            var unmarshaller = RetireGrantResponseUnmarshaller.Instance;

            return Invoke<RetireGrantRequest,RetireGrantResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Retires a grant. To clean up, you can retire a grant when you're done using it. You
        /// should revoke a grant when you intend to actively deny operations that depend on it.
        /// The following are permitted to call this API:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The AWS account (root user) under which the grant was created
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <code>RetiringPrincipal</code>, if present in the grant
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <code>GranteePrincipal</code>, if <code>RetireGrant</code> is an operation specified
        /// in the grant
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You must identify the grant to retire by its grant token or by a combination of the
        /// grant ID and the Amazon Resource Name (ARN) of the customer master key (CMK). A grant
        /// token is a unique variable-length base64-encoded string. A grant ID is a 64 character
        /// unique identifier of a grant. The <a>CreateGrant</a> operation returns both.
        /// </para>
        /// </summary>
        /// <param name="grantToken">Token that identifies the grant to be retired.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RetireGrant service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantIdException">
        /// The request was rejected because the specified <code>GrantId</code> is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantTokenException">
        /// The request was rejected because the specified grant token is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/RetireGrant">REST API Reference for RetireGrant Operation</seealso>
        public virtual Task<RetireGrantResponse> RetireGrantAsync(string grantToken, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new RetireGrantRequest();
            request.GrantToken = grantToken;
            return RetireGrantAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RetireGrant operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RetireGrant operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/RetireGrant">REST API Reference for RetireGrant Operation</seealso>
        public virtual Task<RetireGrantResponse> RetireGrantAsync(RetireGrantRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = RetireGrantRequestMarshaller.Instance;
            var unmarshaller = RetireGrantResponseUnmarshaller.Instance;

            return InvokeAsync<RetireGrantRequest,RetireGrantResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RevokeGrant

        internal virtual RevokeGrantResponse RevokeGrant(RevokeGrantRequest request)
        {
            var marshaller = RevokeGrantRequestMarshaller.Instance;
            var unmarshaller = RevokeGrantResponseUnmarshaller.Instance;

            return Invoke<RevokeGrantRequest,RevokeGrantResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Revokes the specified grant for the specified customer master key (CMK). You can revoke
        /// a grant to actively deny operations that depend on it.
        /// 
        ///  
        /// <para>
        /// To perform this operation on a CMK in a different AWS account, specify the key ARN
        /// in the value of the <code>KeyId</code> parameter.
        /// </para>
        /// </summary>
        /// <param name="grantId">Identifier of the grant to be revoked.</param>
        /// <param name="keyId">A unique identifier for the customer master key associated with the grant. Specify the key ID or the Amazon Resource Name (ARN) of the CMK. To specify a CMK in a different AWS account, you must use the key ARN. For example: <ul> <li> Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> </ul> To get the key ID and key ARN for a CMK, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RevokeGrant service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantIdException">
        /// The request was rejected because the specified <code>GrantId</code> is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/RevokeGrant">REST API Reference for RevokeGrant Operation</seealso>
        public virtual Task<RevokeGrantResponse> RevokeGrantAsync(string grantId, string keyId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new RevokeGrantRequest();
            request.GrantId = grantId;
            request.KeyId = keyId;
            return RevokeGrantAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RevokeGrant operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RevokeGrant operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/RevokeGrant">REST API Reference for RevokeGrant Operation</seealso>
        public virtual Task<RevokeGrantResponse> RevokeGrantAsync(RevokeGrantRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = RevokeGrantRequestMarshaller.Instance;
            var unmarshaller = RevokeGrantResponseUnmarshaller.Instance;

            return InvokeAsync<RevokeGrantRequest,RevokeGrantResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ScheduleKeyDeletion

        internal virtual ScheduleKeyDeletionResponse ScheduleKeyDeletion(ScheduleKeyDeletionRequest request)
        {
            var marshaller = ScheduleKeyDeletionRequestMarshaller.Instance;
            var unmarshaller = ScheduleKeyDeletionResponseUnmarshaller.Instance;

            return Invoke<ScheduleKeyDeletionRequest,ScheduleKeyDeletionResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Schedules the deletion of a customer master key (CMK). You may provide a waiting period,
        /// specified in days, before deletion occurs. If you do not provide a waiting period,
        /// the default period of 30 days is used. When this operation is successful, the state
        /// of the CMK changes to <code>PendingDeletion</code>. Before the waiting period ends,
        /// you can use <a>CancelKeyDeletion</a> to cancel the deletion of the CMK. After the
        /// waiting period ends, AWS KMS deletes the CMK and all AWS KMS data associated with
        /// it, including all aliases that refer to it.
        /// 
        ///  
        /// <para>
        /// You cannot perform this operation on a CMK in a different AWS account.
        /// </para>
        ///  <important> 
        /// <para>
        /// Deleting a CMK is a destructive and potentially dangerous operation. When a CMK is
        /// deleted, all data that was encrypted under the CMK is rendered unrecoverable. To restrict
        /// the use of a CMK without deleting it, use <a>DisableKey</a>.
        /// </para>
        ///  </important> 
        /// <para>
        /// For more information about scheduling a CMK for deletion, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/deleting-keys.html">Deleting
        /// Customer Master Keys</a> in the <i>AWS Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The result of this operation varies with the key state of the CMK. For details, see
        /// <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="keyId">The unique identifier of the customer master key (CMK) to delete. Specify the key ID or the Amazon Resource Name (ARN) of the CMK. For example: <ul> <li> Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> </ul> To get the key ID and key ARN for a CMK, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ScheduleKeyDeletion service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ScheduleKeyDeletion">REST API Reference for ScheduleKeyDeletion Operation</seealso>
        public virtual Task<ScheduleKeyDeletionResponse> ScheduleKeyDeletionAsync(string keyId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new ScheduleKeyDeletionRequest();
            request.KeyId = keyId;
            return ScheduleKeyDeletionAsync(request, cancellationToken);
        }


        /// <summary>
        /// Schedules the deletion of a customer master key (CMK). You may provide a waiting period,
        /// specified in days, before deletion occurs. If you do not provide a waiting period,
        /// the default period of 30 days is used. When this operation is successful, the state
        /// of the CMK changes to <code>PendingDeletion</code>. Before the waiting period ends,
        /// you can use <a>CancelKeyDeletion</a> to cancel the deletion of the CMK. After the
        /// waiting period ends, AWS KMS deletes the CMK and all AWS KMS data associated with
        /// it, including all aliases that refer to it.
        /// 
        ///  
        /// <para>
        /// You cannot perform this operation on a CMK in a different AWS account.
        /// </para>
        ///  <important> 
        /// <para>
        /// Deleting a CMK is a destructive and potentially dangerous operation. When a CMK is
        /// deleted, all data that was encrypted under the CMK is rendered unrecoverable. To restrict
        /// the use of a CMK without deleting it, use <a>DisableKey</a>.
        /// </para>
        ///  </important> 
        /// <para>
        /// For more information about scheduling a CMK for deletion, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/deleting-keys.html">Deleting
        /// Customer Master Keys</a> in the <i>AWS Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The result of this operation varies with the key state of the CMK. For details, see
        /// <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="keyId">The unique identifier of the customer master key (CMK) to delete. Specify the key ID or the Amazon Resource Name (ARN) of the CMK. For example: <ul> <li> Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> </ul> To get the key ID and key ARN for a CMK, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// <param name="pendingWindowInDays">The waiting period, specified in number of days. After the waiting period ends, AWS KMS deletes the customer master key (CMK). This value is optional. If you include a value, it must be between 7 and 30, inclusive. If you do not include a value, it defaults to 30.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ScheduleKeyDeletion service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ScheduleKeyDeletion">REST API Reference for ScheduleKeyDeletion Operation</seealso>
        public virtual Task<ScheduleKeyDeletionResponse> ScheduleKeyDeletionAsync(string keyId, int pendingWindowInDays, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new ScheduleKeyDeletionRequest();
            request.KeyId = keyId;
            request.PendingWindowInDays = pendingWindowInDays;
            return ScheduleKeyDeletionAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ScheduleKeyDeletion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ScheduleKeyDeletion operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ScheduleKeyDeletion">REST API Reference for ScheduleKeyDeletion Operation</seealso>
        public virtual Task<ScheduleKeyDeletionResponse> ScheduleKeyDeletionAsync(ScheduleKeyDeletionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ScheduleKeyDeletionRequestMarshaller.Instance;
            var unmarshaller = ScheduleKeyDeletionResponseUnmarshaller.Instance;

            return InvokeAsync<ScheduleKeyDeletionRequest,ScheduleKeyDeletionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  TagResource

        internal virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var marshaller = TagResourceRequestMarshaller.Instance;
            var unmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceRequest,TagResourceResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = TagResourceRequestMarshaller.Instance;
            var unmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceRequest,TagResourceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UntagResource

        internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var marshaller = UntagResourceRequestMarshaller.Instance;
            var unmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceRequest,UntagResourceResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UntagResourceRequestMarshaller.Instance;
            var unmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceRequest,UntagResourceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateAlias

        internal virtual UpdateAliasResponse UpdateAlias(UpdateAliasRequest request)
        {
            var marshaller = UpdateAliasRequestMarshaller.Instance;
            var unmarshaller = UpdateAliasResponseUnmarshaller.Instance;

            return Invoke<UpdateAliasRequest,UpdateAliasResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Associates an existing alias with a different customer master key (CMK). Each CMK
        /// can have multiple aliases, but the aliases must be unique within the account and region.
        /// You cannot perform this operation on an alias in a different AWS account.
        /// 
        ///  
        /// <para>
        /// This operation works only on existing aliases. To change the alias of a CMK to a new
        /// value, use <a>CreateAlias</a> to create a new alias and <a>DeleteAlias</a> to delete
        /// the old alias.
        /// </para>
        ///  
        /// <para>
        /// Because an alias is not a property of a CMK, you can create, update, and delete the
        /// aliases of a CMK without affecting the CMK. Also, aliases do not appear in the response
        /// from the <a>DescribeKey</a> operation. To get the aliases of all CMKs in the account,
        /// use the <a>ListAliases</a> operation. 
        /// </para>
        ///  
        /// <para>
        /// An alias name can contain only alphanumeric characters, forward slashes (/), underscores
        /// (_), and dashes (-). An alias must start with the word <code>alias</code> followed
        /// by a forward slash (<code>alias/</code>). The alias name can contain only alphanumeric
        /// characters, forward slashes (/), underscores (_), and dashes (-). Alias names cannot
        /// begin with <code>aws</code>; that alias name prefix is reserved by Amazon Web Services
        /// (AWS).
        /// </para>
        ///  
        /// <para>
        /// The result of this operation varies with the key state of the CMK. For details, see
        /// <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="aliasName">String that contains the name of the alias to be modified. The name must start with the word "alias" followed by a forward slash (alias/). Aliases that begin with "alias/aws" are reserved.</param>
        /// <param name="targetKeyId">Unique identifier of the customer master key to be mapped to the alias. Specify the key ID or the Amazon Resource Name (ARN) of the CMK. For example: <ul> <li> Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> </ul> To get the key ID and key ARN for a CMK, use <a>ListKeys</a> or <a>DescribeKey</a>. To verify that the alias is mapped to the correct CMK, use <a>ListAliases</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAlias service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/UpdateAlias">REST API Reference for UpdateAlias Operation</seealso>
        public virtual Task<UpdateAliasResponse> UpdateAliasAsync(string aliasName, string targetKeyId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new UpdateAliasRequest();
            request.AliasName = aliasName;
            request.TargetKeyId = targetKeyId;
            return UpdateAliasAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAlias operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/UpdateAlias">REST API Reference for UpdateAlias Operation</seealso>
        public virtual Task<UpdateAliasResponse> UpdateAliasAsync(UpdateAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateAliasRequestMarshaller.Instance;
            var unmarshaller = UpdateAliasResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAliasRequest,UpdateAliasResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateKeyDescription

        internal virtual UpdateKeyDescriptionResponse UpdateKeyDescription(UpdateKeyDescriptionRequest request)
        {
            var marshaller = UpdateKeyDescriptionRequestMarshaller.Instance;
            var unmarshaller = UpdateKeyDescriptionResponseUnmarshaller.Instance;

            return Invoke<UpdateKeyDescriptionRequest,UpdateKeyDescriptionResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Updates the description of a customer master key (CMK). To see the description of
        /// a CMK, use <a>DescribeKey</a>. 
        /// 
        ///  
        /// <para>
        /// You cannot perform this operation on a CMK in a different AWS account.
        /// </para>
        ///  
        /// <para>
        /// The result of this operation varies with the key state of the CMK. For details, see
        /// <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="keyId">A unique identifier for the customer master key (CMK). Specify the key ID or the Amazon Resource Name (ARN) of the CMK. For example: <ul> <li> Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> </ul> To get the key ID and key ARN for a CMK, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// <param name="description">New description for the CMK.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateKeyDescription service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/UpdateKeyDescription">REST API Reference for UpdateKeyDescription Operation</seealso>
        public virtual Task<UpdateKeyDescriptionResponse> UpdateKeyDescriptionAsync(string keyId, string description, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new UpdateKeyDescriptionRequest();
            request.KeyId = keyId;
            request.Description = description;
            return UpdateKeyDescriptionAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateKeyDescription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateKeyDescription operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/UpdateKeyDescription">REST API Reference for UpdateKeyDescription Operation</seealso>
        public virtual Task<UpdateKeyDescriptionResponse> UpdateKeyDescriptionAsync(UpdateKeyDescriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateKeyDescriptionRequestMarshaller.Instance;
            var unmarshaller = UpdateKeyDescriptionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateKeyDescriptionRequest,UpdateKeyDescriptionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}