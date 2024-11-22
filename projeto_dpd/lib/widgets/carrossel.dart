import 'package:flutter/material.dart';
import 'package:projeto_dpd/page/horariosdpd.dart';
import 'card.dart';

class CardCarousel extends StatelessWidget {
  final Future<List<Map<String, dynamic>>> items;

  const CardCarousel({required this.items, super.key});

  @override
  Widget build(BuildContext context) {
    return FutureBuilder<List<Map<String, dynamic>>>(
      future: items, // Aguardando o futuro dos itens
      builder: (context, snapshot) {
        if (snapshot.connectionState == ConnectionState.waiting) {
          return Center(child: CircularProgressIndicator()); // Exibe um loading enquanto os dados são carregados
        } else if (snapshot.hasError) {
          return Center(child: Text('Erro ao carregar os dados')); // Exibe erro se algo der errado
        } else if (snapshot.hasData) {
          final items = snapshot.data!; // Obtém os dados quando disponíveis

          return PageView.builder(
            itemCount: items.length,
            controller: PageController(viewportFraction: 0.85, initialPage: 0),
            itemBuilder: (context, index) {
              final item = items[index];
              return Padding(
                padding: const EdgeInsets.symmetric(horizontal: 8.0),
                child: CardDpd(
                  name: item['name']!,
                  image: item['image']!,
                  onTap: () {
                    Navigator.push(context, MaterialPageRoute(builder: (context) {
                      return MonitorPage(monitorName: item['name']!, monitorImage: item['image']!);
                    }));  
                  },
                ),
              );
            },
          );
        } else {
          return Center(child: Text('Nenhum dado disponível')); // Caso não haja dados
        }
      },
    );
  }
}
