namespace XeonFun.Entites.Enums
{
    public enum Status
    {
        Waiting, // ожидание заказа
        CancelledByShop, // отменен магазином
        CancelledByUser, // отменен пользователем
        Paid, // оплачен
        Sent, // заказ отправлен
        Received, // заказ получен
        Conflicted, // открыт спор
        Reviewed, // оставлен отзыв (финальная ступень)
    }
}
