using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Serilog;

namespace TW.Vault.Lib
{
    public class ASPUtil
    {
        private static ILogger logger = Log.ForContext(typeof(ASPUtil));
        public IWebHostEnvironment HostingEnvironment { get; private set; }
        String basePath;

        public ASPUtil(IWebHostEnvironment hostingEnvironment, String basePath = "")
        {
            this.HostingEnvironment = hostingEnvironment;
            this.basePath = basePath;
            logger.Information("ASPUtil initialized with WebRootPath: {webRootPath}, ContentRootPath: {contentRootPath}, BasePath: {basePath}", 
                hostingEnvironment.WebRootPath, 
                hostingEnvironment.ContentRootPath,
                basePath);
        }

        public bool UseProductionScripts => HostingEnvironment.IsProduction() || Configuration.Security.ForceEnableObfuscatedScripts;
        public String ObfuscationPathRoot => Path.Combine(HostingEnvironment.ContentRootPath, Configuration.Initialization.ScriptCompilationOutputPath);

        public String GetFilePath(String relativePath)
        {
            if (String.IsNullOrWhiteSpace(relativePath))
            {
                logger.Warning("GetFilePath called with null or empty relativePath");
                return null;
            }

            String rootPath = Path.Combine(HostingEnvironment.WebRootPath, basePath);
            String fullPath = Path.Combine(rootPath, relativePath);
            String absolutePath = Path.GetFullPath(fullPath);

            logger.Information("Resolving file path - Relative: {relativePath}, Root: {rootPath}, Full: {fullPath}, Absolute: {absolutePath}", 
                relativePath, rootPath, fullPath, absolutePath);

            //  Prevent directory traversal
            if (!absolutePath.StartsWith(rootPath))
            {
                logger.Warning("Directory traversal attempt detected - Path: {absolutePath}, Root: {rootPath}", absolutePath, rootPath);
                return null;
            }

            if (File.Exists(absolutePath))
            {
                logger.Information("File exists: {absolutePath}", absolutePath);
                return absolutePath;
            }
            else
            {
                logger.Warning("File does not exist: {absolutePath}", absolutePath);
                return absolutePath;
            }
        }

        public String GetObfuscatedPath(String fileName)
        {
            var path = Path.Combine(ObfuscationPathRoot, fileName);
            logger.Information("Getting obfuscated path for {fileName}: {path}", fileName, path);
            return path;
        }
    }
}
