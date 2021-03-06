using System.Collections.Generic;

namespace Wired.CodeAnalysis;

public abstract class SyntaxNode
{
    public abstract SyntaxKind Kind { get; }

    public abstract IEnumerable<SyntaxNode> GetChildren();
}