﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Spartacus.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Spartacus.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /*
        /// *  This file has been created by using the existing Ghidra ExportFunctionInfoScript.java script as a guide.
        /// *  One would ask &quot;Why don&apos;t you save this output as JSON? Wouldn&apos;t that be easier?&quot; And the answer is &quot;yes, it would be&quot;,
        /// *  however I want to keep Spartacus a standalone executable, and adding a NuGet package for JSON would break that.
        /// */
        ///
        ///import java.util.*;
        ///import java.nio.file.Files;
        ///import java.nio.file.Paths;
        ///import java.nio.charset.Charset;
        ///
        ///import ghidra.app.script.GhidraScri [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string ExportFunctionDefinitionsINI_java {
            get {
                return ResourceManager.GetString("ExportFunctionDefinitionsINI.java", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Usage: Spartacus.exe --mode com [--help] [OPTIONS]
        ///
        ///--procmon               Location (file) of the SysInternals Process Monitor procmon.exe or procmon64.exe
        ///--pml                   Location (file) to store the ProcMon event log file. If the file exists,
        ///                        it will be overwritten. When used with --existing it will indicate
        ///                        the event log file to read from and will not be overwritten.
        ///--pmc                   Define a custom ProcMon (PMC) file to use. This file [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string help_com_txt {
            get {
                return ResourceManager.GetString("help\\com.txt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Usage: Spartacus.exe --mode detect [--help]
        ///
        ///This mode does not support any additional options..
        /// </summary>
        internal static string help_detect_txt {
            get {
                return ResourceManager.GetString("help\\detect.txt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Usage: Spartacus.exe --mode dll [--help] [OPTIONS]
        ///
        ///--procmon               Location (file) of the SysInternals Process Monitor procmon.exe or procmon64.exe
        ///--pml                   Location (file) to store the ProcMon event log file. If the file exists,
        ///                        it will be overwritten. When used with --existing it will indicate
        ///                        the event log file to read from and will not be overwritten.
        ///--pmc                   Define a custom ProcMon (PMC) file to use. This file [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string help_dll_txt {
            get {
                return ResourceManager.GetString("help\\dll.txt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Usage: Spartacus.exe --mode [dll|proxy|com|detect] [--help] [OPTIONS]
        ///
        ///Supported Modes
        ///---------------
        ///
        ///dll                     Identify DLL hijacking vulnerabilities.
        ///proxy                   Generate Visual Studio solutions for DLL proxy files.
        ///com                     Identify COM hijacking vulnerabilities.
        ///detect                  Identify DLLs that are proxying calls (like &apos;DLL Hijacking in progress&apos;).
        ///                        This isn&apos;t a feature to be relied upon, it&apos;s there to get the low hangi [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string help_main_txt {
            get {
                return ResourceManager.GetString("help\\main.txt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Usage: Spartacus.exe --mode proxy [--help] [OPTIONS]
        ///
        ///--ghidra                Path to Ghidra&apos;s &apos;analyzeHeadless.bat&apos; file.
        ///--dll                   Path to the DLL you want to proxy, and can include multiple instances of this argument.
        ///--solution              Path to the directory where the solution of the proxy will be stored.
        ///--overwrite             If the --solution path already exists, use this flag to overwrite it.
        ///--only                  Generate proxy functions only for functions defined in this [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string help_proxy_txt {
            get {
                return ResourceManager.GetString("help\\proxy.txt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to #pragma once
        ///
        ///%_PRAGMA_COMMENTS_%
        ///
        ///#include &quot;windows.h&quot;
        ///#include &quot;ios&quot;
        ///#include &quot;fstream&quot;
        ///
        ///%_TYPEDEF_%
        ///
        ///// Remove this line if you aren&apos;t proxying any functions.
        ///HMODULE hModule = LoadLibrary(L&quot;%_REAL_DLL_%&quot;);
        ///
        ///BOOL APIENTRY DllMain(HMODULE hModule, DWORD  ul_reason_for_call, LPVOID lpReserved)
        ///{
        ///    switch (ul_reason_for_call)
        ///    {
        ///    case DLL_PROCESS_ATTACH:
        ///    case DLL_THREAD_ATTACH:
        ///    case DLL_THREAD_DETACH:
        ///    case DLL_PROCESS_DETACH:
        ///        break;
        ///    }
        ///    return TRUE;
        /// [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string solution_dllmain_cpp {
            get {
                return ResourceManager.GetString("solution\\dllmain.cpp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to // Microsoft Visual C++ generated resource script.
        /////
        ///#include &quot;resource.h&quot;
        ///
        ///#define APSTUDIO_READONLY_SYMBOLS
        ////////////////////////////////////////////////////////////////////////////////
        /////
        ///// Generated from the TEXTINCLUDE 2 resource.
        /////
        ///#include &quot;winres.h&quot;
        ///
        ////////////////////////////////////////////////////////////////////////////////
        ///#undef APSTUDIO_READONLY_SYMBOLS
        ///
        ////////////////////////////////////////////////////////////////////////////////
        ///// English (United Kingdom) resources
        ///
        ///#if  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string solution_proxy_rc {
            get {
                return ResourceManager.GetString("solution\\proxy.rc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Microsoft Visual Studio Solution File, Format Version 12.00
        ///# Visual Studio Version 17
        ///VisualStudioVersion = 17.4.33213.308
        ///MinimumVisualStudioVersion = 10.0.40219.1
        ///Project(&quot;{8BC9CEB8-8B4A-11D0-8D11-00A0C91BC942}&quot;) = &quot;%_PROJECTNAME_%&quot;, &quot;%_PROJECTNAME_%.vcxproj&quot;, &quot;{6FCED408-75B2-4EF9-9E5F-3EC58B19249B}&quot;
        ///EndProject
        ///Global
        ///	GlobalSection(SolutionConfigurationPlatforms) = preSolution
        ///		Debug|x64 = Debug|x64
        ///		Debug|x86 = Debug|x86
        ///		Release|x64 = Release|x64
        ///		Release|x86 = Release|x86
        ///	EndGlobalSe [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string solution_proxy_sln {
            get {
                return ResourceManager.GetString("solution\\proxy.sln", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;Project DefaultTargets=&quot;Build&quot; xmlns=&quot;http://schemas.microsoft.com/developer/msbuild/2003&quot;&gt;
        ///  &lt;ItemGroup Label=&quot;ProjectConfigurations&quot;&gt;
        ///    &lt;ProjectConfiguration Include=&quot;Debug|Win32&quot;&gt;
        ///      &lt;Configuration&gt;Debug&lt;/Configuration&gt;
        ///      &lt;Platform&gt;Win32&lt;/Platform&gt;
        ///    &lt;/ProjectConfiguration&gt;
        ///    &lt;ProjectConfiguration Include=&quot;Release|Win32&quot;&gt;
        ///      &lt;Configuration&gt;Release&lt;/Configuration&gt;
        ///      &lt;Platform&gt;Win32&lt;/Platform&gt;
        ///    &lt;/ProjectConfiguration&gt;
        ///    &lt;ProjectCon [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string solution_proxy_vcxproj {
            get {
                return ResourceManager.GetString("solution\\proxy.vcxproj", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to //{{NO_DEPENDENCIES}}
        ///// Microsoft Visual C++ generated include file.
        ///// Used by proxy.rc
        ///
        ///// Next default values for new objects
        ///// 
        ///#ifdef APSTUDIO_INVOKED
        ///#ifndef APSTUDIO_READONLY_SYMBOLS
        ///#define _APS_NEXT_RESOURCE_VALUE        101
        ///#define _APS_NEXT_COMMAND_VALUE         40001
        ///#define _APS_NEXT_CONTROL_VALUE         1001
        ///#define _APS_NEXT_SYMED_VALUE           101
        ///#endif
        ///#endif
        ///.
        /// </summary>
        internal static string solution_resource_h {
            get {
                return ResourceManager.GetString("solution\\resource.h", resourceCulture);
            }
        }
    }
}
