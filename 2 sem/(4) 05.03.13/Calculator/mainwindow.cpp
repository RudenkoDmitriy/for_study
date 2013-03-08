#include "mainwindow.h"
#include "ui_mainwindow.h"
#include "QObject"
#include "QString"

MainWindow::MainWindow(QWidget *parent) :
    QMainWindow(parent),
    ui(new Ui::MainWindow)
{
    ui->setupUi(this);
    connect(ui->left_spinBox, SIGNAL(valueChanged(int)), this, SLOT(getResult()));
    connect(ui->right_spinBox, SIGNAL(valueChanged(int)), this, SLOT(getResult()));
    connect(ui->comboBox, SIGNAL(currentTextChanged(QString)), this, SLOT(getResult()));
}

MainWindow::~MainWindow()
{
    delete ui;
}

int result(int num1, int num2, QString sign)
{
    if (sign == "+")
        return num1 + num2;
    if (sign == "-")
        return num1 - num2;
    if (sign == "*")
        return num1 * num2;
    if (sign == "/")
        return num1 / num2;
    return 0;
}

int MainWindow::getFirstNumber()
{
    return ui->left_spinBox->value();
}

int MainWindow::getSecondNumber()
{
    return ui->right_spinBox->value();
}

QString MainWindow::getSign()
{
    return ui->comboBox->currentText();
}

void MainWindow::getResult()
{
     int temp = result(MainWindow::getFirstNumber(), MainWindow::getSecondNumber(), MainWindow::getSign());
     QString resultStr;
     resultStr.setNum(temp);
     ui->lineEdit->setText(resultStr);
}


