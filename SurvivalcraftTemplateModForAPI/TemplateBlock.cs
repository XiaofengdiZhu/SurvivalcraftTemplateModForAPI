using Engine;
using Engine.Graphics;

namespace Game {
    // 新增方块都需要在一个 .csv 文件中注册
    // All new blocks must be registered in a .csv file.
    public class TemplateBlock : CubeBlock {
        public Texture2D m_texture;

        public override void Initialize() {
            base.Initialize();
            CanBeBuiltIntoFurniture = true;
            m_texture = ContentManager.Get<Texture2D>("Textures/GVGuidedDispenserBlock");
            int contents = BlocksManager.GetBlockIndex<TemplateBlock>();
            Log.Information($"Survivalcraft Template Mod: Template Block Loaded (Contents: {contents}). 来自生存战争示例模组：示例方块已加载（ID：{contents}）。");
        }

        public override int GetFaceTextureSlot(int face, int value) => face == 4 ? 1 : 0;

        public override int GetTextureSlotCount(int value) => 2;

        public override Texture2D GetDefaultTexture(int value) => m_texture;

        // Belows are old way to use a custom texture. Since API 1.9.2.1, you can use GetDefaultTexture instead.
        // 以下是旧的使用自定义纹理的方法。自 API 1.9.2.1 起，你可以使用 GetDefaultTexture 代替。
        /*public override void GenerateTerrainVertices(BlockGeometryGenerator generator, TerrainGeometry geometry, int value, int x, int y, int z) {
            generator.GenerateCubeVertices(
                this,
                value,
                x,
                y,
                z,
                Color.White,
                geometry.GetGeometry(m_texture).OpaqueSubsetsByFace
            );
        }

        public override void DrawBlock(PrimitivesRenderer3D primitivesRenderer,
            int value,
            Color color,
            float size,
            ref Matrix matrix,
            DrawBlockEnvironmentData environmentData) {
            BlocksManager.DrawCubeBlock(
                primitivesRenderer,
                value,
                new Vector3(size),
                1f,
                ref matrix,
                color,
                color,
                environmentData,
                m_texture
            );
        }*/
    }
}