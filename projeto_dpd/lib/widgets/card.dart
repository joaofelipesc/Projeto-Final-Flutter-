import 'package:flutter/material.dart';

class CardDpd extends StatelessWidget {
  final String name;
  final String image;

  CardDpd({required this.name, required this.image, super.key});

  @override
  Widget build(BuildContext context) {
    final screenWidth = MediaQuery.of(context).size.width;
    final screenHeight = MediaQuery.of(context).size.height;

    return Container(
      child: Stack( 
        children: [
          Positioned(
            top: 5,
            left: 10,
            right: 10,
            child: Column(
              children: [
                Container(
                  child: Text(
                    name,
                    style: TextStyle(
                      fontSize: 20,
                      fontWeight: FontWeight.bold,
                    ),
                  ),
                ),
                Container(
                  child: Image.network(
                    image,
                    width: screenWidth * 0.5,
                    height: screenHeight * 0.5,
                  ),
                ),
              ],
            ),
          ),
        ],
      ),
    );
  }
}
