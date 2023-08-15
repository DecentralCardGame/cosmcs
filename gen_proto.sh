cd ./cosmos-sdk/proto

buf generate --template ../../buf.gen.types.yaml --include-imports
buf generate --template ../../buf.gen.client.yaml $(find | grep /tx.proto | awk '{print "--path="$1}' | xargs)
for path in $(find | grep /query.proto); do
    buf generate --template ../../buf.gen.grpc.yaml -o "../../buf$(python -c "print('/'.join(i.capitalize() for i in \"$(echo $path | sed "s/query.proto//g" | sed 's/\.//g')\".split('/')))")" $path
    echo "../../buf$(python -c "print('/'.join(i.capitalize() for i in \"$(echo $path | sed "s/query.proto//g" | sed 's/\.//g')\".split('/')))")"
done

cd ../../