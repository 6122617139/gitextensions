        public static byte[] GetResetWorkTreeLinesAsPatch([NotNull] GitModule module, [NotNull] string text, int selectionPosition, int selectionLength, [NotNull] Encoding fileContentEncoding)
            string body = ToResetWorkTreeLinesPatch(selectedChunks);
        public static byte[] GetSelectedLinesAsPatch([NotNull] string text, int selectionPosition, int selectionLength, bool isIndex, [NotNull] Encoding fileContentEncoding, bool isNewFile)
            string body = ToIndexPatch(selectedChunks, isIndex, isWholeFile: false);
            string body = ToIndexPatch(selectedChunks, isIndex: false, isWholeFile: true);
        private static string ToResetWorkTreeLinesPatch([NotNull, ItemNotNull] IEnumerable<Chunk> chunks)
                return subChunk.ToResetWorkTreeLinesPatch(ref addedCount, ref removedCount, ref wereSelectedLines);
        private static string ToIndexPatch([NotNull, ItemNotNull] IEnumerable<Chunk> chunks, bool isIndex, bool isWholeFile)
                return subChunk.ToIndexPatch(ref addedCount, ref removedCount, ref wereSelectedLines, isIndex, isWholeFile);
        public string ToIndexPatch(ref int addedCount, ref int removedCount, ref bool wereSelectedLines, bool isIndex, bool isWholeFile)
                else if (!isIndex)
                else if (isIndex)
            if (PostContext.Count == 0 && (!isIndex || selectedLastRemovedLine))
            if (PostContext.Count == 0 && (selectedLastLine || isIndex || isWholeFile))
        public string ToResetWorkTreeLinesPatch(ref int addedCount, ref int removedCount, ref bool wereSelectedLines)