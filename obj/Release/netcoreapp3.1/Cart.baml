   M S B A M L   `   `   `  ����   	menu-repo    menu_repo.Cart   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006       � SizeToContent$  WidthAndHeight=� � Title$
 Cart�� � 	Resources    ItemListBoxItem �� 
TargetType �� Property �� Value �� Path �� RelativeSource �� AncestorType	 �� 
TargetType
 ��Name J� SnapsToDevicePixels �� Triggers P� Property P� Value �� 
TargetName ]� 
Conditions �� Property �� Value  ItemTemplateStyle � RowDefinitions �� Orientation �� FallbackValue  CarItemTemplateStyle � ColumnDefinitions��%  &	        &	 [    &	 R    �� " ��.���  � ��
 ���� ��  � ��$ Stretch=���  � �� �� $ VerticalContentAlignment� �� " ����  � ��$ 2q���  � �� �� "	 ��.R��� $
 Bd��$
 true��#��z��#��z��#��z��._��� #��z��#��z��# z  P�  �@��
IsSelected$
 true��. ��� $ Bd�� � �� �	#FFCFCFCF]�  ��  �@��
IsSelected$
 true����  �@��IsSelectionActive$ false��./��� $ Bd��# � �� � ���� # � �� � ��P�  � {�$ false��. ��� # � �� � ��P�  �@J�IsMouseOver$
 True��. ��� $ Bd�� � �� �	#FFCCCCCC�� .R�� $
��Item��$��0,0,0,0q�$	��440��$��Stretch=�$��Stretch=�.+��� $��Stretch=�$��Stretch=�� $��0��$��Stretch=�$��Stretch=� �� $
��Auto ��� $
��Auto �.+��� $��0��$ Vertical=�$
��Left=�$��2,2,2,0q�.+��� $��	30,0,30,0q�$ 
Horizontal=�$��0��.+��� $��NoWrap=�$��13(����� *name+�� $	�� - ��$��NoWrap=�$��13(��� $��NoWrap=�$��13(����� *price+�� $��	30,0,30,0q�$ 
Horizontal=�$��0��.+��� $��Weight: ��$��NoWrap=�$��13(��� $��NoWrap=�$��14(����� *weight.value+$	 N/A���� $��NoWrap=�$��14(����� *weight.unitOfMeasure+� $��5q�$��1��$��1��$	��470��$��Stretch=�$��Bottom=�.+��� $��Stretch=�$��Stretch=����	#FFE6E6EA�� .R�� $
��Item��$��0,0,0,0q�$	��440��$��Stretch=�$��Stretch=�.+��� $��Stretch=�$��Stretch=�� $��0��$��Stretch=�$��Stretch=� �� $
��Auto ��� $
��Auto �.+�� $��0�� �� $
��Auto ��� $
��Auto �.+��� $��0��$ Vertical=�$
��Left=�$	��250��$��2,2,2,0q�� $��5q�$��1��$��1��$	��470��$��Stretch=�$��Bottom=�.+��� $��Stretch=�$��Stretch=����	#FFE6E6EA.��� $��10q� �� $
��Auto ��� $
��Auto �.+�� $��1�� �� $
��Auto ��� $	��400 ��� $
��Auto �.+�� $��0�� �� $
��Auto ��� $
��Auto �.+��� $ 
Horizontal=�$��Right=�$��0,5,10,0q�$��0��$��1���� $ 
Horizontal=�$��Right=�$
��10,5q�$��1��$��1��.+��� $ 
Horizontal=��� -   $��Discounted_Stackpanel��$ 
Horizontal=�$y�	Collapsed=�.+��� $	�� - ��$��NoWrap=�$��13(��� -   $��DiscountTotalHeader��$��Discounted Cost: ���� -   $��DiscountTotal������ *	cartTotal+$ 0���� -    ��Name$ Price��$��Price��$
��Left=�$��37��$��
290,75,0,0q�$	��Top=�$��90��$��25(�$��Aharoni)� J� RenderTransformOrigin$ 0.447,1.123&�$��1���� -   $��ShoppingCart��$��1��$
��true��$��Stretch=�$��Stretch=�$��0q�#���  #���   $��39,10.333,38,195.667q����� $ 	CartItems�.@��� $V��PNachos                                                                    $10.49���� $Y��SBeer                                                                         $10.51���� $S��MHamburger                                                              $15.59���� $N��HChicken Ceasar Wrap                                               $15.59������ .R�$� �� $��2��$ 
Horizontal=�.+�� �� -   $
 item��$
��Item��$
��Left=�$��40��$��	39,77,0,0q�$	��Top=�$��78��$��25(�$��Aharoni)�$ 0.598,1.986&��� -    ��Name$ 	CartTotal��$��$52.18��$��341,215,51,152q�$ 0.346,0.545&�$��1�� �� TextAlignment$ Center=�$��25(�z�V� .~���  �� ScaleX$ 1Q��� �� T�  T� X$ 16.016Q��� -   $ 	item_Copy��$��Total:��$
��Left=�$��53��$��274,209.333,0,0q�$	��Top=�$��78��$��30(�$��Aharoni)�$ 0.598,1.986&�$��1���� -	    ��Name$ CheckOut��$��Place Order��$��18(�$��50��$��37,404,213,72.667q�$��1���� $
��Left=�$��4��$��
10,119,0,0q�
���   �$	��Top=�$	��377��
���   �$��1���� -
   $ Payment��$��Payment��$��18(�$��50��$��221,404,29,72.667q�$��1���� -   $ 	CallStaff��$��
Call Staff��$��18(�$��50��$��129,467,121,9.667q�$��1���� -   $ My_Cart��$��My Cart:��$
��Left=�$��58��$��0,37,0,0q�$	��Top=�$	��150��$��25(�$��Aharoni)�$��2��