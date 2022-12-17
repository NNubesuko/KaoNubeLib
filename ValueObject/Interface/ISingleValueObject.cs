namespace KaoNubeLib.ValueObject {

    public interface ISingleValueObject<T> {

        T Value { get; }
        T MIN { get; }
        T MAX { get; }

    }

}