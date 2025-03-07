namespace DotNet.Testcontainers.Configurations
{
  using System;
  using System.Text.Json;
  using DotNet.Testcontainers.Images;
  using JetBrains.Annotations;

  /// <summary>
  /// A Testcontainers custom configuration.
  /// </summary>
  internal interface ICustomConfiguration
  {
    /// <summary>
    /// Gets the Docker config custom configuration.
    /// </summary>
    /// <returns>The Docker config custom configuration.</returns>
    /// <remarks>https://dotnet.testcontainers.org/custom_configuration/.</remarks>
    [CanBeNull]
    string GetDockerConfig();

    /// <summary>
    /// Gets the Docker host custom configuration.
    /// </summary>
    /// <returns>The Docker host custom configuration.</returns>
    /// <remarks>https://dotnet.testcontainers.org/custom_configuration/.</remarks>
    [CanBeNull]
    Uri GetDockerHost();

    /// <summary>
    /// Gets the Docker host override custom configuration.
    /// </summary>
    /// <returns>The Docker host override custom configuration.</returns>
    /// <remarks>https://dotnet.testcontainers.org/custom_configuration/.</remarks>
    [CanBeNull]
    string GetDockerHostOverride();

    /// <summary>
    /// Gets the Docker socket override custom configuration.
    /// </summary>
    /// <returns>The Docker socket override custom configuration.</returns>
    /// <remarks>https://dotnet.testcontainers.org/custom_configuration/.</remarks>
    [CanBeNull]
    string GetDockerSocketOverride();

    /// <summary>
    /// Gets the Docker registry authentication custom configuration.
    /// </summary>
    /// <returns>The Docker authentication custom configuration.</returns>
    /// <remarks>https://dotnet.testcontainers.org/custom_configuration/.</remarks>
    [CanBeNull]
    JsonDocument GetDockerAuthConfig();

    /// <summary>
    /// Gets the Docker certificates path custom configuration.
    /// </summary>
    /// <returns>The Docker certificates path custom configuration.</returns>
    /// <remarks>https://dotnet.testcontainers.org/custom_configuration/.</remarks>
    [CanBeNull]
    string GetDockerCertPath();

    /// <summary>
    /// Gets the Docker TLS custom configuration.
    /// </summary>
    /// <returns>The Docker TLS custom configuration.</returns>
    /// <remarks>https://dotnet.testcontainers.org/custom_configuration/.</remarks>
    bool GetDockerTls();

    /// <summary>
    /// Gets the Docker TLS verify custom configuration.
    /// </summary>
    /// <returns>The Docker TLS verify custom configuration.</returns>
    /// <remarks>https://dotnet.testcontainers.org/custom_configuration/.</remarks>
    bool GetDockerTlsVerify();

    /// <summary>
    /// Gets the Ryuk disabled custom configuration.
    /// </summary>
    /// <returns>The Ryuk disabled custom configuration.</returns>
    /// <remarks>https://dotnet.testcontainers.org/custom_configuration/.</remarks>
    bool GetRyukDisabled();

    /// <summary>
    /// Gets the Ryuk container image custom configuration.
    /// </summary>
    /// <returns>The Ryuk container image custom configuration.</returns>
    /// <remarks>https://dotnet.testcontainers.org/custom_configuration/.</remarks>
    [CanBeNull]
    IDockerImage GetRyukContainerImage();

    /// <summary>
    /// Gets the Docker Hub image name prefix custom configuration.
    /// </summary>
    /// <returns>The Docker Hub image name prefix custom configuration.</returns>
    /// <remarks>https://dotnet.testcontainers.org/custom_configuration/.</remarks>
    [CanBeNull]
    string GetHubImageNamePrefix();
  }
}
