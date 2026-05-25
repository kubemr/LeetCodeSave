namespace LeetCodeSave.Trie;

public class SearchSuggestionsSystem //71
{
    public IList<IList<string>> SuggestedProducts(string[] products, string searchWord) {
        var root = new Node();

        foreach (var product in products.OrderBy(it => it))
        {
            var current = root;
            foreach (var ch in product)
            {
                current = current.Children[ch - 'a'] ??= new Node();
                current.Words.Add(product);
            }
        }

        var result = new List<IList<string>>();
        var node = root;
        foreach (var ch in searchWord)
        {
            node = node?.Children[ch - 'a'];
            result.Add(node is null ? Array.Empty<string>() : node.Words.Take(3).ToArray());
        }

        return result;
    }

    class Node
    {
        public HashSet<string> Words = new HashSet<string>();
        public Node?[] Children { get; } = new Node?[26];
    };
}