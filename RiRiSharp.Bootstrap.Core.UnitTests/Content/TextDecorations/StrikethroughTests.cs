﻿using RiRiSharp.Bootstrap.Core.Content.Abbreviations;
using RiRiSharp.Bootstrap.Core.Content.TextDecorations;

namespace RiRiSharp.Bootstrap.Core.UnitTests.Content.TextDecorations;

public class StrikethroughTests()
    : BootstrapCoreComponentTests<Strikethrough>(@"<span class=""text-decoration-line-through {0}"" {1}></span>");