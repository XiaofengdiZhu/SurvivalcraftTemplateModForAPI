using Engine;
using Engine.Graphics;

namespace Game {
    public class TemplateBlock : CubeBlock {
        public Texture2D m_texture;

        public override void Initialize() {
            base.Initialize();
            m_texture = ContentManager.Get<Texture2D>("Textures/GVGuidedDispenserBlock");
            int contents = BlocksManager.GetBlockIndex<TemplateBlock>();
            Log.Information($"Survivalcraft Template Mod: Template Block Loaded (Contents: {contents}). 来自生存战争示例模组：示例方块已加载（ID：{contents}）。");
        }

        public override int GetFaceTextureSlot(int face, int value) => face == 4 ? 1 : 0;

        public override int GetTextureSlotCount(int value) => 2;

        public override void GenerateTerrainVertices(BlockGeometryGenerator generator, TerrainGeometry geometry, int value, int x, int y, int z) {
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
        }
    }
}