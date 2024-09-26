用于将单色GIF动图或者整个目录下的所有单张图片转换成内嵌数组单个变量的形式
每8个点1个字节，水平扫描，低位在前高位在后，符合U8G2的drawXBMP方式输出
目录下的单张图片要求为单色无透明通道并且宽高一致，会转换成一个大数组，使用下标显示其中某张图片
可用于128*64的单色OLED屏幕显示动画用
![微信截图_20240926102023](https://github.com/user-attachments/assets/24b99656-95ee-4cc9-bf98-2412611e3b10)
![微信截图_20240926102030](https://github.com/user-attachments/assets/80f38d76-77f8-4bc2-a63a-c63a05658499)
![微信截图_20240926102118](https://github.com/user-attachments/assets/3dddc18e-0587-472a-a143-a6b8409a4b2c)
![微信截图_20240926102145](https://github.com/user-attachments/assets/42ea124b-7845-462e-85b0-94e3981a5dca)
