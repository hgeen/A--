using Aminusminus.Content;
using Antlr4.Runtime.Misc;
using System.Runtime.Intrinsics.X86;
using System.Transactions;

namespace Aminusminus;

public class AmmVisitor : AmmBaseVisitor<object?>
{
    private Dictionary<string, object?> Variables { get; } = new();

    public AmmVisitor()
    {
        Variables["pi"] = Math.PI;

        Variables["print"] = new Func<object?[], object?>(Print);
    }

    private object? Print(object?[] args)
    {
        foreach (var arg in args)
        { 
            Console.WriteLine(arg);
        }

        return null;
    }

    public override object? VisitFunctionCall(AmmParser.FunctionCallContext context)
    {
        var name = context.IDENTIFIER().GetText();
        var args = context.expression().Select(Visit).ToArray();

        if (!Variables.TryGetValue(name, out var value))
            throw new Exception($"(function) {name} is not defined.");

        if (!(Variables[name] is Func<object?[], object?> func))
            throw new Exception($"(variable) {name} is not a function.");

        return func(args);
    }

    public override object? VisitAssignment(AmmParser.AssignmentContext context)
    {
        var varName = context.IDENTIFIER().GetText();

        var value = Visit(context.expression());

        Variables[varName] = value;

        return null;
    }

    public override object? VisitIdentifierExpression(AmmParser.IdentifierExpressionContext context)
    {
        var varName = context.IDENTIFIER().GetText();

        if (!Variables.ContainsKey(varName))
        {
            throw new Exception($"Variable {varName} does not exist.");
        }

        return Variables[varName];
    }

    public override object? VisitConstant(AmmParser.ConstantContext context)
    {
        if (context.INTEGER() is { } i)
            return int.Parse(i.GetText());

        if (context.FLOAT() is { } f)
            return int.Parse(f.GetText());

        if (context.STRING() is { } s)
            return s.GetText()[1..^1];

        if (context.BOOL() is { } b)
            return b.GetText() == "true";

        if (context.NULL() is { })
            return null;

        throw new NotImplementedException();
    }

    public override object? VisitAddititveExpression(AmmParser.AddititveExpressionContext context)
    {
        var left = Visit(context.expression(0));
        var right = Visit(context.expression(1));

        var op = context.addOp().GetText();

        return op switch
        {
            "+" => Add(left, right),
            "-" => Subtract(left, right),
            _ => throw new NotImplementedException()
        };
    }

    private object? Add(object? left, object? right)
    {
        if (left is int l && right is int r)
            return l + r;

        if (left is float lf && right is float rf)
            return lf + rf;

        if (left is int lInt && right is float rFloat)
            return lInt + rFloat;

        if (left is float lFloat && right is int rInt)
            return lFloat + rInt;

        if (left is string || right is string)
            return $"{left}{right}";

        throw new Exception($"Cannot add values/types of {left?.GetType()} and {right?.GetType()}");
    }

    private object? Subtract(object? left, object? right)
    {
        if (left is int l && right is int r)
            return l - r;

        if (left is float lf && right is float rf)
            return lf - rf;

        if (left is int lInt && right is float rFloat)
            return lInt - rFloat;

        if (left is float lFloat && right is int rInt)
            return lFloat - rInt;

        if (left is string || right is string)
            return $"{left}{right}";

        throw new Exception($"Cannot subtract values/types of {left?.GetType()} and {right?.GetType()}");
    }

    public override object? VisitMultiplicativeExpression([NotNull] AmmParser.MultiplicativeExpressionContext context)
    {
        var left = Visit(context.expression(0));
        var right = Visit(context.expression(1));

        var op = context.multOp().GetText();

        return op switch
        {
            "*" => Multiply(left, right),
            "/" => Divide(left, right),
            _ => throw new NotImplementedException()
        };
    }

    private object? Multiply(object? left, object? right)
    {
        if (left is int l && right is int r)
            return l * r;

        if (left is float lf && right is float rf)
            return lf * rf;

        if (left is int lInt && right is float rFloat)
            return lInt * rFloat;

        if (left is float lFloat && right is int rInt)
            return lFloat * rInt;

        throw new Exception($"Cannot multiply values/types of {left?.GetType()} and {right?.GetType()}");
    }

    private object? Divide(object? left, object? right)
    {
        if (left is int l && right is int r)
            return l / r;

        if (left is float lf && right is float rf)
            return lf / rf;

        if (left is int lInt && right is float rFloat)
            return lInt / rFloat;

        if (left is float lFloat && right is int rInt)
            return lFloat / rInt;

        throw new Exception($"Cannot divide values/types of {left?.GetType()} and {right?.GetType()}");
    }

    public override object? VisitWhileBlock(AmmParser.WhileBlockContext context)
    {
        Func<object?, bool> condition = context.WHILE().GetText() == "while"
            ? IsTrue
            : IsFalse
        ;

        if (condition(Visit(context.expression())))
        {
            do
            {
                Visit(context.block());
            } while (condition(Visit(context.expression())));
        }
        else
        {
            Visit(context.elseIfBlock());
        }

        return null;
    }

    public override object? VisitComparisonExpression(AmmParser.ComparisonExpressionContext context)
    {
        var left = Visit(context.expression(0));
        var right = Visit(context.expression(1));

        var op = context.compareOp().GetText();

        return op switch
        {
            "==" => IsEquals(left, right),
            "!=" => NotEquals(left, right),
            ">" => GreaterThan(left, right),
            "<" => LessThan(left, right),
            ">=" => GreaterThanOrEquals(left, right),
            "<=" => LessThanOrEquals(left, right),
            _ => throw new NotImplementedException()
        };
    }

    private bool IsEquals(object? left, object? right)
    {
        if (left is int l && right is int r)
            return l == r;

        if (left is float lf && right is float rf)
            return lf == rf;

        if (left is int lInt && right is float rFloat)
            return lInt == rFloat;

        if (left is float lFloat && right is int rInt)
            return lFloat == rInt;

        throw new Exception($"Cannot compare values/types of {left?.GetType()} and {right?.GetType()}");
    }

    private bool NotEquals(object? left, object? right)
    {
        if (left is int l && right is int r)
            return l != r;

        if (left is float lf && right is float rf)
            return lf != rf;

        if (left is int lInt && right is float rFloat)
            return lInt != rFloat;

        if (left is float lFloat && right is int rInt)
            return lFloat != rInt;

        throw new Exception($"Cannot compare values/types of {left?.GetType()} and {right?.GetType()}");
    }

    private bool GreaterThan(object? left, object? right)
    {
        if (left is int l && right is int r)
            return l > r;

        if (left is float lf && right is float rf)
            return lf > rf;

        if (left is int lInt && right is float rFloat)
            return lInt > rFloat;

        if (left is float lFloat && right is int rInt)
            return lFloat > rInt;

        throw new Exception($"Cannot compare values/types of {left?.GetType()} and {right?.GetType()}");
    }

    private bool LessThan(object? left, object? right)
    {
        if (left is int l && right is int r)
            return l < r;

        if (left is float lf && right is float rf)
            return lf < rf;

        if (left is int lInt && right is float rFloat)
            return lInt < rFloat;

        if (left is float lFloat && right is int rInt)
            return lFloat < rInt;

        throw new Exception($"Cannot compare values/types of {left?.GetType()} and {right?.GetType()}");
    }

    private bool GreaterThanOrEquals(object? left, object? right)
    {
        if (left is int l && right is int r)
            return l >= r;

        if (left is float lf && right is float rf)
            return lf >= rf;

        if (left is int lInt && right is float rFloat)
            return lInt >= rFloat;

        if (left is float lFloat && right is int rInt)
            return lFloat >= rInt;

        throw new Exception($"Cannot compare values/types of {left?.GetType()} and {right?.GetType()}");
    }

    private bool LessThanOrEquals(object? left, object? right)
    {
        if (left is int l && right is int r)
            return l <= r;

        if (left is float lf && right is float rf)
            return lf <= rf;

        if (left is int lInt && right is float rFloat)
            return lInt <= rFloat;

        if (left is float lFloat && right is int rInt)
            return lFloat <= rInt;

        throw new Exception($"Cannot compare values/types of {left?.GetType()} and {right?.GetType()}");
    }


    private bool IsTrue(object? value)
    {
        if(value is bool b)
            return b;

        throw new Exception("Value is not a bool");
    }

    public bool IsFalse(object? value) => !IsTrue(value);
}