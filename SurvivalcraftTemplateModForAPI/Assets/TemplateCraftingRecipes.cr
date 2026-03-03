<Mod xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xsi:noNamespaceSchemaLocation="https://gitee.com/SC-SPM/SurvivalcraftApi/raw/SCAPI1.9/Survivalcraft/Content/Assets/CraftingRecipes.xsd">
  <!-- Add a new crafting recipe -->
  <!--添加一个新合成配方-->
  <Recipe Result="TemplateBlock" ResultCount="1" RequiredHeatLevel="0" a="dirt" b="coalore" c="wood" d="planks" Description="[0]">
    "abc"
    ""
    " d"
  </Recipe>
  <!-- Modify a crafting recipe (Only one "New-" is allowed) -->
  <!-- 修改一个合成配方（只能有一个 "New-"） -->
  <Recipe Result="WoodenClubBlock" New-ResultCount="2" RequiredHeatLevel="0" a="stick" b="planks" Description="[0]">
    "b"
    "b"
    "a"
  </Recipe>
  <!-- Remove a crafting recipe. If you want to modify the placement, you have to remove it first, then add a new recipe with the new placement -->
  <!-- 删除一个合成配方。如果你想改变摆放方式，你需要先删除它，再添加一个带有新摆放方式的新配方 -->
  <Recipe Result="StoneAxeBlock" ResultCount="1" RequiredHeatLevel="0" a="stick" b="stonechunk" Description="[0]" Remove="true">
    "bb"
    "ba"
    " a"
  </Recipe>
</Mod>