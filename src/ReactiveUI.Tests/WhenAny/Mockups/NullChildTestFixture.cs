// Copyright (c) 2023 .NET Foundation and Contributors. All rights reserved.
// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for full license information.

namespace ReactiveUI.Tests.WhenAny.Mockups;

internal static class NullChildTestFixture
{
    internal static Container Instance() => new();

    internal class Container : ReactiveObject
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        private Child _child;
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

        public Child Child
        {
            get => _child;
            set => this.RaiseAndSetIfChanged(ref _child, value);
        }
    }

    internal class Child
    {
        public Child() => Foo = new Subject<int>();

        public Subject<int> Foo { get; }
    }
}
