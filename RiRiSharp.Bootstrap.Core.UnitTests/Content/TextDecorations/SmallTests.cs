﻿using RiRiSharp.Bootstrap.Core.Content.Abbreviations;
using RiRiSharp.Bootstrap.Core.Content.TextDecorations;

namespace RiRiSharp.Bootstrap.Core.UnitTests.Content.TextDecorations;

public class SmallTests() : BootstrapCoreComponentTests<Small>(@"<span class=""small {0}"" {1}></span>");