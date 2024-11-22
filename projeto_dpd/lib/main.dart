import 'package:flutter/material.dart';
import 'package:projeto_dpd/widgets/card.dart';
import 'package:projeto_dpd/widgets/carrossel.dart';
import 'package:projeto_dpd/monitorservice.dart';

void main() {
  runApp(MyApp());
}

class MyApp extends StatelessWidget {
  Future<List<Map<String, dynamic>>> monitors = MonitorService().fetchMonitors();

  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      home: Scaffold(
        appBar: AppBar(title: const Text('Carrossel de Cards')),
        body: Center(
          child: CardCarousel(items: monitors),
        ),
      ),
    );
  }
}
