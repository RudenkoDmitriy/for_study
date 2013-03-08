/********************************************************************************
** Form generated from reading UI file 'mainwindow.ui'
**
** Created by: Qt User Interface Compiler version 5.0.1
**
** WARNING! All changes made in this file will be lost when recompiling UI file!
********************************************************************************/

#ifndef UI_MAINWINDOW_H
#define UI_MAINWINDOW_H

#include <QtCore/QVariant>
#include <QtWidgets/QAction>
#include <QtWidgets/QApplication>
#include <QtWidgets/QButtonGroup>
#include <QtWidgets/QComboBox>
#include <QtWidgets/QHeaderView>
#include <QtWidgets/QLineEdit>
#include <QtWidgets/QMainWindow>
#include <QtWidgets/QPushButton>
#include <QtWidgets/QSpinBox>
#include <QtWidgets/QStatusBar>
#include <QtWidgets/QWidget>

QT_BEGIN_NAMESPACE

class Ui_MainWindow
{
public:
    QAction *actionSimple_Calculator;
    QWidget *centralWidget;
    QSpinBox *left_spinBox;
    QSpinBox *right_spinBox;
    QComboBox *comboBox;
    QLineEdit *lineEdit;
    QPushButton *but_Exit;
    QStatusBar *statusBar;

    void setupUi(QMainWindow *MainWindow)
    {
        if (MainWindow->objectName().isEmpty())
            MainWindow->setObjectName(QStringLiteral("MainWindow"));
        MainWindow->resize(394, 157);
        MainWindow->setStyleSheet(QStringLiteral(""));
        actionSimple_Calculator = new QAction(MainWindow);
        actionSimple_Calculator->setObjectName(QStringLiteral("actionSimple_Calculator"));
        centralWidget = new QWidget(MainWindow);
        centralWidget->setObjectName(QStringLiteral("centralWidget"));
        left_spinBox = new QSpinBox(centralWidget);
        left_spinBox->setObjectName(QStringLiteral("left_spinBox"));
        left_spinBox->setGeometry(QRect(20, 10, 71, 61));
        left_spinBox->setStyleSheet(QStringLiteral("font: 20pt \"MS Shell Dlg 2\";"));
        right_spinBox = new QSpinBox(centralWidget);
        right_spinBox->setObjectName(QStringLiteral("right_spinBox"));
        right_spinBox->setGeometry(QRect(160, 10, 81, 61));
        right_spinBox->setStyleSheet(QStringLiteral("font: 20pt \"MS Shell Dlg 2\";"));
        comboBox = new QComboBox(centralWidget);
        comboBox->setObjectName(QStringLiteral("comboBox"));
        comboBox->setGeometry(QRect(90, 10, 69, 61));
        comboBox->setStyleSheet(QStringLiteral("font: 20pt \"MS Shell Dlg 2\";  "));
        lineEdit = new QLineEdit(centralWidget);
        lineEdit->setObjectName(QStringLiteral("lineEdit"));
        lineEdit->setGeometry(QRect(240, 10, 131, 61));
        lineEdit->setStyleSheet(QStringLiteral("font: 20pt \"MS Shell Dlg 2\";"));
        but_Exit = new QPushButton(centralWidget);
        but_Exit->setObjectName(QStringLiteral("but_Exit"));
        but_Exit->setGeometry(QRect(20, 80, 75, 23));
        MainWindow->setCentralWidget(centralWidget);
        statusBar = new QStatusBar(MainWindow);
        statusBar->setObjectName(QStringLiteral("statusBar"));
        MainWindow->setStatusBar(statusBar);

        retranslateUi(MainWindow);
        QObject::connect(but_Exit, SIGNAL(clicked()), MainWindow, SLOT(close()));

        QMetaObject::connectSlotsByName(MainWindow);
    } // setupUi

    void retranslateUi(QMainWindow *MainWindow)
    {
        MainWindow->setWindowTitle(QApplication::translate("MainWindow", "MainWindow", 0));
        actionSimple_Calculator->setText(QApplication::translate("MainWindow", "Simple Calculator", 0));
        comboBox->clear();
        comboBox->insertItems(0, QStringList()
         << QApplication::translate("MainWindow", "+", 0)
         << QApplication::translate("MainWindow", "-", 0)
         << QApplication::translate("MainWindow", "*", 0)
         << QApplication::translate("MainWindow", "/", 0)
        );
        but_Exit->setText(QApplication::translate("MainWindow", "Exit", 0));
    } // retranslateUi

};

namespace Ui {
    class MainWindow: public Ui_MainWindow {};
} // namespace Ui

QT_END_NAMESPACE

#endif // UI_MAINWINDOW_H
