# BattlePong

### 操作

玩家1（左）：WS

玩家2（右）：↑↓

### 测试功能

**一个方块的大小为1*1**

找到Scenes中的MainScene，选择场景中的GameManager，在右侧有多个属性可修改：

Width/Height Bound: 整个场景的长、宽

Player Velocity: 玩家速度

Ball Velocity: 球的速度

Ball Scale: 球的大小（1=1个方块大小）

Player Size: 玩家初始为n*n个方块

Player Pos：玩家初始距离中心的横向距离

游戏会根据参数自动生成边界，若对场景大小等做大幅度修改则需要修改相机的size