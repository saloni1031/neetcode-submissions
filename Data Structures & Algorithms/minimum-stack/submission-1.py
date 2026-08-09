class MinStack:

    def __init__(self):
        self.min = None
        self.stack = list()
        

    def push(self, val: int) -> None:
        self.stack.append(val)
        if self.min is None or val < self.min:
            self.min = val
        

    def pop(self) -> None:
        self.stack.pop()
        if self.stack:
            self.min = min(self.stack)
        else:
            self.min = None
        

    def top(self) -> int:
        return self.stack[-1]
        

    def getMin(self) -> int:
        return self.min
        
