using System.Linq.Expressions;

namespace Starcounter.Linq.Visitors
{
    public class GroupByVisitor<TEntity> : StatelessVisitor<QueryBuilder<TEntity>>
    {
        public static GroupByVisitor<TEntity> Instance = new GroupByVisitor<TEntity>();

        public override void VisitMember(MemberExpression node, QueryBuilder<TEntity> state)
        {
            if (node.Expression is ParameterExpression param)
                state.WriteGroupBy(param.Type.SourceName());
            else
                Visit(node.Expression, state);
            state.WriteGroupBy("." + node.Member.Name);
        }
    }
}
