class HuffmanEncoder
{
    /// <summary>
    /// Funzione di Encoding che, preso in input il contenuto di un file di testo, 
    /// mi restituisce una stringa contenente la rispettiva codifica secondo 
    /// l'algoritmo di Huffman
    /// </summary>
    /// <param name="content">Contenuto da codificare</param>
    /// <returns>Il contenuto `content` codificato.</returns>
    public static string Encode(string content)
    {
        // 1) Calcolo la tabella delle frequenze di ciascun carattere
        var frequencyTable = BuildFrequencyTable(content);
        // 2) Costruisco l'albero di Huffman a partire da quelle frequenze
        var huffmanTree = BuildHuffmanTree(frequencyTable);
        // 3) Calcolo i codici per ciascun carattere
        var codes = CalculateHuffmanCodes(huffmanTree);

        // 4) Dati i codici appena calcolati, completare la codifica!
        return HuffmanEncode(content, codes); 
    }
}